using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Trakit.Commands;

namespace Trakit.Tools {
	/// <summary>
	/// 
	/// </summary>
	public class ConvertSelfUser : TrakitConverter<SelfUser> {
		public override SelfUser ConvertFrom(JsonReader reader, Type type, SelfUser user, bool existing, JsonSerializer serializer) {
			var obj = JObject.Load(reader);
			user = new SelfUser() {
				General = obj.ToObject<SelfUserGeneral>(serializer),
				Advanced = obj.ToObject<SelfUserAdvanced>(serializer),
			};
			user.v = obj["v"].Select(p => (int)p).ToArray();
			return user;
		}
	}
}