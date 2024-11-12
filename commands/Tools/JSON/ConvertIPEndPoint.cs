using System;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace trakit.tools {
	/// <summary>
	/// 
	/// </summary>
	public class ConvertIPEndPoint : TrakitConverter<IPEndPoint> {
		public override IPEndPoint convertFrom(JsonReader reader, Type type, IPEndPoint ipEnd, bool existing, JsonSerializer serializer) {
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
		public override void convertTo(JsonWriter writer, IPEndPoint value, JsonSerializer serializer) => writer.WriteValue(value.ToString());
	}
}