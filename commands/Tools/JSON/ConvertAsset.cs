using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using trakit.objects;

namespace trakit.tools {
	/// <summary>
	/// 
	/// </summary>
	public class ConvertAsset : TrakitConverter<Asset> {
		public override Asset convertFrom(JsonReader reader, Type type, Asset asset, bool existing, JsonSerializer serializer) {
			var obj = JObject.Load(reader);
			if (!Enum.TryParse(obj["kind"]?.ToString(), true, out AssetType kind)) throw new JsonException();
			if (
				bool.TryParse(obj["deleted"]?.ToString(), out _)
				|| bool.TryParse(obj["suspended"]?.ToString(), out _)
			) {
				switch (kind) {
					case AssetType.person:
						asset = new Person() {
							general = obj.ToObject<PersonGeneral>(serializer),
						};
						break;
					case AssetType.vehicle:
						asset = new Vehicle() {
							general = obj.ToObject<VehicleGeneral>(serializer),
						};
						break;
					case AssetType.trailer:
						asset = new Trailer() {
							general = obj.ToObject<TrailerGeneral>(serializer),
						};
						break;
					case AssetType.asset:
						asset = new Asset() {
							general = obj.ToObject<AssetGeneral>(serializer),
						};
						break;
				}
				asset.general.deleted = true;
			} else {
				switch (kind) {
					case AssetType.person:
						asset = new Person() {
							general = obj.ToObject<PersonGeneral>(serializer),
							advanced = obj.ToObject<AssetAdvanced>(serializer),
							dispatch = obj["dispatch"].ToObject<AssetDispatch>(serializer),
						};
						break;
					case AssetType.vehicle:
						asset = new Vehicle() {
							general = obj.ToObject<VehicleGeneral>(serializer),
							advanced = obj.ToObject<VehicleAdvanced>(serializer),
							dispatch = obj["dispatch"].ToObject<AssetDispatch>(serializer),
						};
						break;
					case AssetType.trailer:
						asset = new Trailer() {
							general = obj.ToObject<TrailerGeneral>(serializer),
							advanced = obj.ToObject<AssetAdvanced>(serializer),
							dispatch = obj["dispatch"].ToObject<AssetDispatch>(serializer),
						};
						break;
					case AssetType.asset:
						asset = new Asset() {
							general = obj.ToObject<AssetGeneral>(serializer),
							advanced = obj.ToObject<AssetAdvanced>(serializer),
							dispatch = obj["dispatch"].ToObject<AssetDispatch>(serializer),
						};
						break;
				}
				asset.dispatch.id = asset.id;
				asset.dispatch.company = asset.company;
				asset.v = obj["v"].Select(p => (int)p).ToArray();
			}

			return asset;
		}
	}
}