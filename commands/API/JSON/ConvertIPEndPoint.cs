using System;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Trakit.Tools {
	/// <summary>
	/// 
	/// </summary>
	public class ConvertIPEndPoint : TrakitConverter<IPEndPoint> {
		public override IPEndPoint ConvertFrom(JsonReader reader, Type type, IPEndPoint ipEnd, bool existing, JsonSerializer serializer) {
			var token = JToken.Load(reader);
			switch (token.Type) {
				case JTokenType.Object:
					var obj = (JObject)token;
					ipEnd = new IPEndPoint(
						obj["address"].ToObject<IPAddress>(serializer),
						obj["port"].Value<int>()
					);
					break;
				case JTokenType.String:
					string[] addressPort = token.Value<string>().Split(':');
					ipEnd = new IPEndPoint(
						IPAddress.Parse(addressPort[0]),
						int.Parse(addressPort[1])
					);
					break;
			}
			return ipEnd;
		}
		public override void ConvertTo(JsonWriter writer, IPEndPoint value, JsonSerializer serializer) => writer.WriteValue(value.ToString());
	}
}