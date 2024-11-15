using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Trakit.Objects;

namespace Trakit.Tools {
	/// <summary>
	/// 
	/// </summary>
	public class ConvertUser : TrakitConverter<User> {
		public override User ConvertFrom(JsonReader reader, Type type, User user, bool existing, JsonSerializer serializer) {
			var obj = JObject.Load(reader);
			user = new User() {
				General = obj.ToObject<UserGeneral>(serializer),
				Advanced = obj.ToObject<UserAdvanced>(serializer),
			};
			user.v = obj["v"].Select(p => (int)p).ToArray();
			return user;
		}
	}
}