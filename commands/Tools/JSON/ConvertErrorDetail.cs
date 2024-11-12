using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using trakit.commands;

namespace trakit.tools {
	/// <summary>
	/// 
	/// </summary>
	public class ConvertErrorDetail : TrakitConverter<ErrorDetail> {
		public override ErrorDetail convertFrom(JsonReader reader, Type type, ErrorDetail detail, bool existing, JsonSerializer serializer) {
			var obj = JObject.Load(reader);
			if (!Enum.TryParse(obj["kind"]?.ToString(), true, out ErrorDetailType kind)) throw new JsonException("Unknown ErrorDetailType");
			switch (kind) {
				case ErrorDetailType.badIds: detail = obj.ToObject<ErrorDetailBadIds>(serializer); break;
				case ErrorDetailType.badIndexes: detail = obj.ToObject<ErrorDetailBadIndexes>(serializer); break;
				case ErrorDetailType.badKeys: detail = obj.ToObject<ErrorDetailBadKeys>(serializer); break;
				case ErrorDetailType.batch: detail = obj.ToObject<ErrorDetailBatch>(serializer); break;
				case ErrorDetailType.contactInUse: detail = obj.ToObject<ErrorDetailContactInUse>(serializer); break;
				case ErrorDetailType.count: detail = obj.ToObject<ErrorDetailCount>(serializer); break;
				case ErrorDetailType.@enum: detail = obj.ToObject<ErrorDetailEnum>(serializer); break;
				case ErrorDetailType.escalation: detail = obj.ToObject<ErrorDetailEscalation>(serializer); break;
				case ErrorDetailType.externals: detail = obj.ToObject<ErrorDetailExternals>(serializer); break;
				case ErrorDetailType.formTemplateInUse: detail = obj.ToObject<ErrorDetailFormTemplateInUse>(serializer); break;
				case ErrorDetailType.input: detail = obj.ToObject<ErrorDetailInput>(serializer); break;
				case ErrorDetailType.locked: detail = obj.ToObject<ErrorDetailLocked>(serializer); break;
				case ErrorDetailType.minMax: detail = obj.ToObject<ErrorDetailMinMax>(serializer); break;
				case ErrorDetailType.parent: detail = obj.ToObject<ErrorDetailParent>(serializer); break;
				case ErrorDetailType.parse: detail = obj.ToObject<ErrorDetailParent>(serializer); break;
				case ErrorDetailType.phone: detail = obj.ToObject<ErrorDetailPhone>(serializer); break;
				case ErrorDetailType.secret: detail = obj.ToObject<ErrorDetailSecret>(serializer); break;
				case ErrorDetailType.stack: detail = obj.ToObject<ErrorDetailStack>(serializer); break;
				case ErrorDetailType.throttled: detail = obj.ToObject<ErrorDetailThrottled>(serializer); break;
				case ErrorDetailType.userGroupInUse: detail = obj.ToObject<ErrorDetailUserGroupInUse>(serializer); break;
				default: throw new JsonException("Unsupported ErrorDetailType");
			}
			return detail;
		}
	}
}