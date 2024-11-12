using System;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace trakit.tools {
	/// <summary>
	/// 
	/// </summary>
	public class ConvertIPAddress : TrakitConverter<IPAddress> {
		public override IPAddress convertFrom(JsonReader reader, Type type, IPAddress ipEnd, bool existing, JsonSerializer serializer) {
			var token = JToken.Load(reader);
			return IPAddress.Parse(token.Value<string>());
		}
		public override void convertTo(JsonWriter writer, IPAddress value, JsonSerializer serializer) => writer.WriteValue(value.ToString());
	}
}