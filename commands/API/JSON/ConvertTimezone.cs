using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Trakit.Objects;

namespace Trakit.Tools {
	/// <summary>
	/// 
	/// </summary>
	public class ConvertTimezone : TrakitConverter<Timezone> {
		public static Timezone findById(string id) {
			id = Text.codify(id);
			var zone = string.IsNullOrEmpty(id)
					? null
					: TimeZoneInfo.GetSystemTimeZones()
								.FirstOrDefault(tz => id == Text.codify(tz.Id));
			return zone == null
				? null
				: new Timezone() {
					code = id,
					name = zone.DisplayName,
					offset = (short)zone.BaseUtcOffset.TotalMinutes,
					dst = zone.IsDaylightSavingTime(DateTime.UtcNow),
				};
		}

		public override Timezone convertFrom(JsonReader reader, Type type, Timezone tz, bool existing, JsonSerializer serializer) {
			string code = reader.Value.ToString();
			return ConvertTimezone.findById(code)
				?? throw new TimeZoneNotFoundException(code + " not found");
		}
		public override void convertTo(JsonWriter writer, Timezone value, JsonSerializer serializer) {
			var obj = new JValue(Text.codify(value.code));
			obj.WriteTo(writer);
		}
	}
}