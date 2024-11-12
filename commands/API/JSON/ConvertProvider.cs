using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using trakit.objects;

namespace trakit.tools {
	/// <summary>
	/// 
	/// </summary>
	public class ConvertProvider : TrakitConverter<Provider> {
		public override Provider convertFrom(JsonReader reader, Type type, Provider provider, bool existing, JsonSerializer serializer) {
			var obj = JObject.Load(reader);
			provider = new Provider() {
				general = obj.ToObject<ProviderGeneral>(serializer),
				advanced = obj.ToObject<ProviderAdvanced>(serializer),
				control = obj.ToObject<ProviderControl>(serializer),
			};
			provider.v = obj["v"].Select(p => (int)p).ToArray();
			return provider;
		}
	}
}