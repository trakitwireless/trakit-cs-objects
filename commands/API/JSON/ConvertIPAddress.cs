using System;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Trakit.Tools {
	/// <summary>
	/// 
	/// </summary>
	public class ConvertIPAddress : TrakitConverter<IPAddress> {
		public override IPAddress ConvertFrom(JsonReader reader, Type type, IPAddress ipEnd, bool existing, JsonSerializer serializer) {
			var token = JToken.Load(reader);
			return IPAddress.Parse(token.Value<string>());
		}
		public override void ConvertTo(JsonWriter writer, IPAddress value, JsonSerializer serializer) => writer.WriteValue(value.ToString());
	}
}