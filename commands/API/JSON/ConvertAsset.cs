using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Trakit.Objects;

namespace Trakit.Tools {
	/// <summary>
	/// 
	/// </summary>
	public class ConvertAsset : TrakitConverter<Asset> {
		public override Asset ConvertFrom(JsonReader reader, Type type, Asset asset, bool existing, JsonSerializer serializer) {
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
							General = obj.ToObject<AssetGeneral>(serializer),
						};
						break;
				}
				asset.General.deleted = true;
			} else {
				switch (kind) {
					case AssetType.person:
						asset = new Person() {
							general = obj.ToObject<PersonGeneral>(serializer),
							Advanced = obj.ToObject<AssetAdvanced>(serializer),
							Dispatch = obj["dispatch"].ToObject<AssetDispatch>(serializer),
						};
						break;
					case AssetType.vehicle:
						asset = new Vehicle() {
							general = obj.ToObject<VehicleGeneral>(serializer),
							advanced = obj.ToObject<VehicleAdvanced>(serializer),
							Dispatch = obj["dispatch"].ToObject<AssetDispatch>(serializer),
						};
						break;
					case AssetType.trailer:
						asset = new Trailer() {
							general = obj.ToObject<TrailerGeneral>(serializer),
							Advanced = obj.ToObject<AssetAdvanced>(serializer),
							Dispatch = obj["dispatch"].ToObject<AssetDispatch>(serializer),
						};
						break;
					case AssetType.asset:
						asset = new Asset() {
							General = obj.ToObject<AssetGeneral>(serializer),
							Advanced = obj.ToObject<AssetAdvanced>(serializer),
							Dispatch = obj["dispatch"].ToObject<AssetDispatch>(serializer),
						};
						break;
				}
				asset.Dispatch.id = asset.id;
				asset.Dispatch.company = asset.company;
				asset.v = obj["v"].Select(p => (int)p).ToArray();
			}

			return asset;
		}
	}
}