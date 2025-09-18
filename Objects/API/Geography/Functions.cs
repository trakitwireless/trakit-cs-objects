using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trakit.Objects {
	/// <summary>
	/// 
	/// </summary>
	public static class Geography {
		public const double EARTH_RADIUS = 6378137;  // meters
		public const double EARTH_ELLIPSOID = 298.257223563;
		public const double EARTH_FLATENING = 1 / EARTH_ELLIPSOID;
		public const double EARTH_RADIUS_MINOR = EARTH_RADIUS - (EARTH_RADIUS * EARTH_FLATENING); // 6356752.3142 meters => wgs84

		const double DEGREES_TO_RADIANS = Math.PI / 180;
		const double RADIANS_TO_DEGREES = 180 / Math.PI;

		public static double NotNaN(double n) => double.IsNaN(n) || double.IsInfinity(n) ? 0 : n;
		static double _clip(double n, double maxValue) => _clip(n, maxValue, -maxValue);
		static double _clip(double n, double maxValue, double minValue)
			=> Math.Min(Math.Max(NotNaN(n), minValue), maxValue);

		/// <summary>
		/// Caps a latitude to between +90 and -90.
		/// Values outside those ranges are capped.
		/// </summary>
		/// <param name="latitude"></param>
		/// <returns>Number between 90 and -90</returns>
		public static double NormalizeLatitude(double latitude)
			=> _clip(latitude, 90);
		/// <summary>
		/// Normalizes a longitude to between +180 and -180.
		/// Values outside those ranges are increased/reduced by 360.
		/// </summary>
		/// <param name="longitude"></param>
		/// <returns>Number between 180 and -180</returns>
		public static double NormalizeLongitude(double longitude)
			=> NotNaN(
				Math.Abs(longitude %= 360) > 180
					? longitude + (longitude < 0 ? 360 : -360)
					: longitude
			);
		/// <summary>
		/// Normalizes a direction of travel to between +0 and +360.
		/// Values outside those ranges are increased/reduced by 360.
		/// </summary>
		/// <param name="heading"></param>
		/// <returns>Number between 0 and 360</returns>
		public static double NormalizeHeading(double heading)
			=> ((NotNaN(heading) % 360) + 360) % 360;
		/// <summary>
		/// Checks to see if the latitude is at the north or south pole (within standard margin of error).
		/// </summary>
		/// <param name="lat"></param>
		/// <returns></returns>
		public static bool LatitudeIsPole(double lat)
			=> Math.Round(Math.Cos(lat * DEGREES_TO_RADIANS), 9) == 0.0;

		/// <summary>
		/// Calculates the distance across the surface of the globe to another coordinate
		/// </summary>
		/// <param name="first"></param>
		/// <param name="second"></param>
		/// <returns>Distance in meters</returns>
		public static double DistanceBetween(LatLng first, LatLng second) {
			double lat1 = first.lat * DEGREES_TO_RADIANS,
				lat2 = second.lat * DEGREES_TO_RADIANS,
				lng1 = first.lng * DEGREES_TO_RADIANS,
				lng2 = second.lng * DEGREES_TO_RADIANS,
				dLat = lat2 - lat1,
				dLng = lng2 - lng1,
				sin_dLat_half = Math.Pow(Math.Sin(dLat / 2), 2),  // minor optimization
				sin_dLng_half = Math.Pow(Math.Sin(dLng / 2), 2),  // minor optimization
				distance = sin_dLat_half + Math.Cos(lat1) * Math.Cos(lat2) * sin_dLng_half;
			return ((2 * Math.Atan2(Math.Sqrt(distance), Math.Sqrt(1 - distance))) * EARTH_RADIUS);
		}
		/// <summary>
		/// Calculates the starting bearing across the surface of the globe from the current coordinate to the given coordinate
		/// </summary>
		/// <param name="second"></param>
		/// <returns>Bearing in degrees (not radians)</returns>
		public static double BearingTo(LatLng first, LatLng second) {
			if (LatitudeIsPole(first.lat)) {  // starting at one of the poles
				return first.lat > 0 ? 180 : 0;
			} else {
				double lat1 = NormalizeLatitude(first.lat) * DEGREES_TO_RADIANS,
					lat2 = NormalizeLatitude(second.lat) * DEGREES_TO_RADIANS,
					dLng = (second.lng - first.lng) * DEGREES_TO_RADIANS,
					cos_lat2 = Math.Cos(lat2),    // minor optimization
					bearing = Math.Atan2(Math.Sin(dLng) * cos_lat2, Math.Cos(lat1) * Math.Sin(lat2) - Math.Sin(lat1) * cos_lat2 * Math.Cos(dLng)) * RADIANS_TO_DEGREES;
				return (bearing + 360) % 360;
			}
		}
		/// <summary>
		/// Returns a new coordinate at the given distance and bearing from this coordinate
		/// </summary>
		/// <param name="meters">Distance</param>
		/// <param name="bearing">Bearing in degrees (not radians)</param>
		/// <returns></returns>
		public static LatLng TranslateTo(LatLng latlng, double meters, double bearing) {
			double distance = meters / EARTH_RADIUS,
				heading = bearing * DEGREES_TO_RADIANS,
				lat1 = latlng.lat * DEGREES_TO_RADIANS,
				lng1 = latlng.lng * DEGREES_TO_RADIANS,
				lat2 = Math.Asin(Math.Sin(lat1) * Math.Cos(distance) + Math.Cos(lat1) * Math.Sin(distance) * Math.Cos(heading)),
				lng2 = lng1 + Math.Atan2(Math.Sin(heading) * Math.Sin(distance) * Math.Cos(lat1), Math.Cos(distance) - Math.Sin(lat1) * Math.Sin(lat2));
			return new LatLng(lat2 * RADIANS_TO_DEGREES, lng2 * RADIANS_TO_DEGREES);
		}

		/// <summary>
		/// The Douglas-Peucker algorithm
		/// </summary>
		/// <param name="source">The source array of coordinates</param>
		/// <param name="tolerance">The distance in meters used as a tolerance for including coordinates</param>
		/// <returns>The array of indexes to keep for the whole reduction</returns>
		static bool[] _douglasPeucker(LatLng[] source, double tolerance) {
			// references the indexes in the source array that should be kept
			var keepers = new bool[source.Length];
			// the queue is initially populated with just the first and last index of the source
			var checkers = new Queue<(int, int)>(new[] { (0, source.Length - 1) });
			// as the loop continues, more entries are added to the queue if they must also be checked
			while (checkers.Count > 0) {
				(int firstIndex, int secondIndex) = checkers.Dequeue();

				// the first and last items are flagged as keepers
				keepers[firstIndex] =
				keepers[secondIndex] = true;

				// we need at least 3 points to check this segment
				// so lastIndex - firstIndex needs to be 2 or more
				if (secondIndex - firstIndex > 1) {
					int farthestIndex = firstIndex;
					double farthestDistance = 0;
					LatLng firstPoint = source[firstIndex],
							lastPoint = source[secondIndex];

					// find the widest orthogonal distance
					for (int i = firstIndex + 1; i < secondIndex; i++) {
						// ABS because circle distance can be negative (to the right of circle)
						// as well as positive (to the left of circle)
						double distance = Math.Abs(DistanceGreatCircle(firstPoint, source[i], lastPoint));
						if (distance > farthestDistance) {
							farthestDistance = distance;
							farthestIndex = i;
						}
					}
					// if a "farthest index" was found (in case tolerance was set to 0.0)
					// and that distance is farther than the tolerance
					if (farthestIndex > firstIndex && farthestDistance >= tolerance) {
						// add the first index and farthest index to the checkers queue
						checkers.Enqueue((firstIndex, farthestIndex));
						// also add the farthest and last index to the checkers queue
						checkers.Enqueue((farthestIndex, secondIndex));
					}
				}
			}
			return keepers;
		}
		/// <summary>
		/// Performs a Douglas-Peucker path reduction on the given coordinates representing a path
		/// </summary>
		/// <param name="latlngs">A list of coordinates representing a path</param>
		/// <param name="tolerance">The distance in meters used as a tolerance for including coordinates</param>
		/// <returns></returns>
		public static LatLng[] ReducePath(IEnumerable<LatLng> latlngs, double tolerance = 0.001) {
			if (tolerance > 0 && latlngs?.Count() > 2) {
				var ids = _douglasPeucker(latlngs.ToArray(), tolerance);
				return latlngs.Where((latlng, index) => ids[index]).ToArray();
			}
			return latlngs?.ToArray() ?? new LatLng[0];
		}
		/// <summary>
		/// Performs a Douglas-Peucker path reduction on the given coordinates representing a polygon.
		/// The points are re-oriented to provide maximum compression.
		/// </summary>
		/// <param name="latlngs">A list of coordinates representing a polygon</param>
		/// <param name="tolerance">The distance in meters used as a tolerance for including coordinates</param>
		/// <returns></returns>
		public static LatLng[] ReducePoly(IEnumerable<LatLng> latlngs, double tolerance = 0.001) {
			if (tolerance > 0 && latlngs?.Count() > 2) {
				FartestBetween(latlngs.ToArray(), out int startIndex, out int secondIndex);
				// re-order the points with the new starting point
				return ReducePath(
					latlngs.Skip(startIndex)
							.Concat(latlngs.Take(startIndex + 1)),  //+1 will add first point as last point
					tolerance
				).ToArray();
			}
			return latlngs?.ToArray() ?? new LatLng[0];
		}
		/// <summary>
		/// Finds and returns the largest distance of all given coordinates.
		/// </summary>
		/// <param name="latlngs">A list of coordinates</param>
		/// <returns></returns>
		public static double FartestBetween(IEnumerable<LatLng> latlngs)
			=> FartestBetween(latlngs?.ToArray(), out _, out _);
		/// <summary>
		/// Finds and returns the largest distance of all given coordinates.
		/// </summary>
		/// <param name="latlngs">A list of coordinates</param>
		/// <param name="firstIndex">Index of the first point that represents the widest section.</param>
		/// <param name="secondIndex">Index of the other point that represents the widest section.</param>
		/// <returns></returns>
		public static double FartestBetween(IEnumerable<LatLng> latlngs, out int firstIndex, out int secondIndex)
			=> FartestBetween(latlngs?.ToArray(), out firstIndex, out secondIndex);
		/// <summary>
		/// Finds and returns the largest distance of all given coordinates.
		/// </summary>
		/// <param name="latlngs">A list of coordinates</param>
		/// <param name="firstIndex">Index of the first point that represents the widest section.</param>
		/// <param name="secondIndex">Index of the other point that represents the widest section.</param>
		/// <returns></returns>
		public static double FartestBetween(LatLng[] latlngs, out int firstIndex, out int secondIndex) {
			firstIndex =
			secondIndex = 0;
			double widest = 0;
			if (latlngs?.Length > 1) {
				for (int i = 0; i < latlngs.Length; i++) {
					for (int j = i + 1; j < latlngs.Length; j++) {
						double distance = DistanceBetween(latlngs[i], latlngs[j]);
						if (distance > widest) {
							firstIndex = i;
							secondIndex = j;
							widest = distance;
						}
					}
				}
			}
			return widest;
		}
		/// <summary>
		/// Calculates the distance of a point from a line around the planet as defined by lineA and lineB.
		/// </summary>
		/// <param name="first">The starting point of the circle</param>
		/// <param name="point">The subject of the result</param>
		/// <param name="second">Used to calculate the bearing around the globe</param>
		/// <returns>Distance in meters.  Negative when point is to the right of line; positive when to the left.</returns>
		public static double DistanceGreatCircle(LatLng first, LatLng point, LatLng second) {
			if (DistanceBetween(first, second) == 0) return DistanceBetween(first, point);
			double aLatRad = first.lat * DEGREES_TO_RADIANS,
				aLngRad = first.lng * DEGREES_TO_RADIANS,
				midLatRad = point.lat * DEGREES_TO_RADIANS,
				midLngRad = point.lng * DEGREES_TO_RADIANS,
				bLatRad = second.lat * DEGREES_TO_RADIANS,
				bLngRad = second.lng * DEGREES_TO_RADIANS,

				aLatSin = Math.Sin(aLatRad),
				aLatCos = Math.Cos(aLatRad),
				aLngSin = Math.Sin(aLngRad),
				aLngCos = Math.Cos(aLngRad),

				midLatSin = Math.Sin(midLatRad),
				midLatCos = Math.Cos(midLatRad),
				midLngSin = Math.Sin(midLngRad),
				midLngCos = Math.Cos(midLngRad),

				bLatSin = Math.Sin(bLatRad),
				bLatCos = Math.Cos(bLatRad),
				bLngSin = Math.Sin(bLngRad),
				bLngCos = Math.Cos(bLngRad),

				cosTheta = aLatSin * bLatSin + aLatCos * bLatCos * (aLngCos * bLngCos + aLngSin * bLngSin),
				inverseSinThetaSquared = 1 - cosTheta * cosTheta;
			return Math.Asin((
				aLatSin * (bLatCos * midLatCos * bLngCos * midLngSin - bLatCos * midLatCos * bLngSin * midLngCos) +
				aLatCos * aLngCos * (bLatCos * midLatSin * bLngSin - bLatSin * midLatCos * midLngSin) +
				aLatCos * aLngSin * (bLatSin * midLatCos * midLngCos - bLatCos * midLatSin * bLngCos)
			) / Math.Sqrt(inverseSinThetaSquared)) * EARTH_RADIUS;
		}

		/// <summary>
		/// Measures the distance between two coordinates using Vincenty's formula instead of Haversine.
		/// </summary>
		/// <param name="first"></param>
		/// <param name="second"></param>
		/// <returns></returns>
		public static double VincentyDistance(LatLng first, LatLng second) {
			double L = (second.lng - first.lng) * DEGREES_TO_RADIANS,
					U1 = Math.Atan((1 - EARTH_FLATENING) * Math.Tan(first.lat * DEGREES_TO_RADIANS)),
					U2 = Math.Atan((1 - EARTH_FLATENING) * Math.Tan(first.lat * DEGREES_TO_RADIANS)),
					sinU1 = Math.Sin(U1),
					cosU1 = Math.Cos(U1),
					sinU2 = Math.Sin(U2),
					cosU2 = Math.Cos(U2),
					lambda = L,
					lambdaP,
					iterLimit = 100,
					sinLambda,
					cosLambda,
					sinSigma,
					cosSigma,
					sigma,
					sinAlpha,
					cosSqAlpha,
					cos2SigmaM,
					C;
			do {
				sinLambda = Math.Sin(lambda);
				cosLambda = Math.Cos(lambda);
				sinSigma = Math.Sqrt((cosU2 * sinLambda) * (cosU2 * sinLambda) + (cosU1 * sinU2 - sinU1 * cosU2 * cosLambda) * (cosU1 * sinU2 - sinU1 * cosU2 * cosLambda));
				if (0 == sinSigma) {
					return 0; // co-incident points
				}
				cosSigma = sinU1 * sinU2 + cosU1 * cosU2 * cosLambda;
				sigma = Math.Atan2(sinSigma, cosSigma);
				sinAlpha = cosU1 * cosU2 * sinLambda / sinSigma;
				cosSqAlpha = 1 - sinAlpha * sinAlpha;
				cos2SigmaM = cosSigma - 2 * sinU1 * sinU2 / cosSqAlpha;
				C = EARTH_FLATENING / 16 * cosSqAlpha * (4 + EARTH_FLATENING * (4 - 3 * cosSqAlpha));
				//	if (isNaN(cos2SigmaM)) {
				//		cos2SigmaM = 0; // equatorial line: cosSqAlpha = 0 (§6)
				//	};
				lambdaP = lambda;
				lambda = L + (1 - C) * EARTH_FLATENING * sinAlpha * (sigma + C * sinSigma * (cos2SigmaM + C * cosSigma * (-1 + 2 * cos2SigmaM * cos2SigmaM)));
			} while (Math.Abs(lambda - lambdaP) > 1e-12 && --iterLimit > 0);

			if (iterLimit == 0) {
				return 0; // formula failed to converge
			}

			double uSq = cosSqAlpha * (EARTH_RADIUS * EARTH_RADIUS - EARTH_RADIUS_MINOR * EARTH_RADIUS_MINOR) / (EARTH_RADIUS_MINOR * EARTH_RADIUS_MINOR),
			    A = 1 + uSq / 16384 * (4096 + uSq * (-768 + uSq * (320 - 175 * uSq))),
			    B = uSq / 1024 * (256 + uSq * (-128 + uSq * (74 - 47 * uSq))),
			    deltaSigma = B * sinSigma * (cos2SigmaM + B / 4 * (cosSigma * (-1 + 2 * cos2SigmaM * cos2SigmaM) - B / 6 * cos2SigmaM * (-3 + 4 * sinSigma * sinSigma) * (-3 + 4 * cos2SigmaM * cos2SigmaM))),
			    s = EARTH_RADIUS_MINOR * A * (sigma - deltaSigma);
			return s;
		}
		/// <summary>
		/// Returns the coordinate from the given stake position with meters and initial bearing.
		/// </summary>
		/// <param name="latlng"></param>
		/// <param name="meters"></param>
		/// <param name="bearing"></param>
		/// <returns></returns>
		public static LatLng VincentyTranslate(LatLng latlng, double meters, double bearing) {
			double alpha1 = bearing * DEGREES_TO_RADIANS,
				sinAlpha1 = Math.Sin(alpha1),
				cosAlpha1 = Math.Cos(alpha1),
				tanU1 = (1 - EARTH_FLATENING) * Math.Tan(latlng.lat * DEGREES_TO_RADIANS),
				cosU1 = 1 / Math.Sqrt((1 + tanU1 * tanU1)), sinU1 = tanU1 * cosU1,
				sigma1 = Math.Atan2(tanU1, cosAlpha1),
				sinAlpha = cosU1 * sinAlpha1,
				cosSqAlpha = 1 - sinAlpha * sinAlpha,
				uSq = cosSqAlpha * (EARTH_RADIUS * EARTH_RADIUS - EARTH_RADIUS_MINOR * EARTH_RADIUS_MINOR) / (EARTH_RADIUS_MINOR * EARTH_RADIUS_MINOR),
				A = 1 + uSq / 16384 * (4096 + uSq * (-768 + uSq * (320 - 175 * uSq))),
				B = uSq / 1024 * (256 + uSq * (-128 + uSq * (74 - 47 * uSq))),
				sigma = meters / (EARTH_RADIUS_MINOR * A),
				sigmaP = 2 * Math.PI,
				cos2SigmaM = 0,
				sinSigma = 0,
				cosSigma = 0,
				deltaSigma;
			while (Math.Abs(sigma - sigmaP) > 1e-12) {
				cos2SigmaM = Math.Cos(2 * sigma1 + sigma);
				sinSigma = Math.Sin(sigma);
				cosSigma = Math.Cos(sigma);
				deltaSigma = B * sinSigma * (cos2SigmaM + B / 4 * (cosSigma * (-1 + 2 * cos2SigmaM * cos2SigmaM) - B / 6 * cos2SigmaM * (-3 + 4 * sinSigma * sinSigma) * (-3 + 4 * cos2SigmaM * cos2SigmaM)));
				sigmaP = sigma;
				sigma = meters / (EARTH_RADIUS_MINOR * A) + deltaSigma;
			}
			double tmp = sinU1 * sinSigma - cosU1 * cosSigma * cosAlpha1,
			    lat2 = Math.Atan2(sinU1 * cosSigma + cosU1 * sinSigma * cosAlpha1, (1 - EARTH_FLATENING) * Math.Sqrt(sinAlpha * sinAlpha + tmp * tmp)),
			    lambda = Math.Atan2(sinSigma * sinAlpha1, cosU1 * cosSigma - sinU1 * sinSigma * cosAlpha1),
			    C = EARTH_FLATENING / 16 * cosSqAlpha * (4 + EARTH_FLATENING * (4 - 3 * cosSqAlpha)),
			    L = lambda - (1 - C) * EARTH_FLATENING * sinAlpha * (sigma + C * sinSigma * (cos2SigmaM + C * cosSigma * (-1 + 2 * cos2SigmaM * cos2SigmaM))),
			    revAz = Math.Atan2(sinAlpha, -tmp); // final bearing
			return new LatLng(lat2 * RADIANS_TO_DEGREES, latlng.lng + (L * RADIANS_TO_DEGREES));
		}

		/// <summary>
		/// A C# implementation to encode a polyline using Google's Encoded Polyline algorithm.
		/// </summary>
		/// <param name="latlngs"></param>
		/// <param name="precision"></param>
		/// <returns>Encoded string</returns>
		public static string EncodePolyline(IEnumerable<LatLng> latlngs, byte precision = 5) {
			var encodedPoints = new StringBuilder();
			Action<int> encode = (diff) => {
				int shifted = diff << 1;
				if (diff < 0) shifted = ~shifted;
				while (shifted >= 0x20) {
					encodedPoints.Append((char)((0x20 | (shifted & 0x1f)) + 63));
					shifted >>= 5;
				}
				encodedPoints.Append((char)(shifted + 63));
			};
			int factor = (int)Math.Pow(10, precision),
				lastLat = 0,
				lastLng = 0;
			foreach (var point in latlngs) {
				int currentLat = (int)Math.Round(point.lat * factor),
					currentLng = (int)Math.Round(point.lng * factor);
				encode(currentLat - lastLat);
				encode(currentLng - lastLng);
				lastLat = currentLat;
				lastLng = currentLng;
			}
			return encodedPoints.ToString();
		}
		/// <summary>
		/// A C# implementation to decode a polyline using Google's Encoded Polyline algorithm.
		/// </summary>
		/// <param name="encodedPoints"></param>
		/// <param name="precision"></param>
		/// <returns></returns>
		public static IEnumerable<LatLng> DecodePolyline(string encodedPoints, byte precision = 5) {
			if (string.IsNullOrEmpty(encodedPoints)) throw new ArgumentNullException("encodedPoints");

			var polylineChars = encodedPoints.ToCharArray();
			int index = 0,
				currentLat = 0,
				currentLng = 0,
				factor = (int)Math.Pow(10, precision);

			while (index < polylineChars.Length) {
				// calculate next latitude
				int sum = 0,
					shifter = 0,
					next5bits;
				do {
					next5bits = (int)polylineChars[index++] - 63;
					sum |= (next5bits & 31) << shifter;
					shifter += 5;
				} while (next5bits >= 32 && index < polylineChars.Length);

				if (index >= polylineChars.Length) break;

				currentLat += (sum & 1) == 1 ? ~(sum >> 1) : (sum >> 1);

				//calculate next longitude
				sum = 0;
				shifter = 0;
				do {
					next5bits = (int)polylineChars[index++] - 63;
					sum |= (next5bits & 31) << shifter;
					shifter += 5;
				} while (next5bits >= 32 && index < polylineChars.Length);

				if (index >= polylineChars.Length && next5bits >= 32)
					break;

				currentLng += (sum & 1) == 1 ? ~(sum >> 1) : (sum >> 1);

				yield return new LatLng(
					Convert.ToDouble(currentLat) / factor,
					Convert.ToDouble(currentLng) / factor
				);
			}
		}
	}
}