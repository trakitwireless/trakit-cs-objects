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
			id = Text.Codify(id);
			var zone = string.IsNullOrEmpty(id)
					? default
					: TimeZoneInfo.GetSystemTimeZones()
								.FirstOrDefault(tz => id == Text.Codify(tz.Id));
			return zone == default
				? default
				: new Timezone() {
					code = id,
					name = zone.DisplayName,
					offset = (short)zone.BaseUtcOffset.TotalMinutes,
					dst = zone.IsDaylightSavingTime(DateTime.UtcNow),
				};
		}

		public override Timezone ConvertFrom(JsonReader reader, Type type, Timezone tz, bool existing, JsonSerializer serializer) {
			string code = reader.Value.ToString();
			return ConvertTimezone.findById(code)
				?? throw new TimeZoneNotFoundException(code + " not found");
		}
		public override void ConvertTo(JsonWriter writer, Timezone value, JsonSerializer serializer) {
			var obj = new JValue(Text.Codify(value.code));
			obj.WriteTo(writer);
		}
	}
}