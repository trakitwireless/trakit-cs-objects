using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using trakit.objects;

namespace trakit.tools {
	/// <summary>
	/// 
	/// </summary>
	public class ConvertUser : TrakitConverter<User> {
		public override User convertFrom(JsonReader reader, Type type, User user, bool existing, JsonSerializer serializer) {
			var obj = JObject.Load(reader);
			user = new User() {
				general = obj.ToObject<UserGeneral>(serializer),
				advanced = obj.ToObject<UserAdvanced>(serializer),
			};
			user.v = obj["v"].Select(p => (int)p).ToArray();
			return user;
		}
	}
}