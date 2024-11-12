using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using trakit.objects;

namespace trakit.tools {
	/// <summary>
	/// 
	/// </summary>
	public class ConvertCompany : TrakitConverter<Company> {
		public override Company convertFrom(JsonReader reader, Type type, Company company, bool existing, JsonSerializer serializer) {
			var obj = JObject.Load(reader);
			if (
				bool.TryParse(obj["deleted"]?.ToString(), out _)
				|| bool.TryParse(obj["suspended"]?.ToString(), out _)
			) {
				company = new Company() {
					general = obj.ToObject<CompanyGeneral>(serializer),
				};
			} else {
				company = new Company() {
					general = obj.ToObject<CompanyGeneral>(serializer),
					directory = obj.ToObject<CompanyDirectory>(serializer),
					policies = obj.ToObject<CompanyPolicies>(serializer),
					styles = obj.ToObject<CompanyStyles>(serializer),
				};
				if (obj["reseller"]?.Type == JTokenType.Object) {
					company.reseller = obj["reseller"].ToObject<CompanyReseller>(serializer);
				}
				company.v = obj["v"].Select(p => (int)p).ToArray();
			}
			return company;
		}
	}
}