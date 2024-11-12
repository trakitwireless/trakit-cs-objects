using System;
using Newtonsoft.Json;

namespace trakit.tools {
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	/// Inspiration for this approach was taken from https://github.com/JamesNK/Newtonsoft.Json/issues/719#issuecomment-2103805140
	/// Which was itself inspired by https://stackoverflow.com/questions/16085805/recursively-call-jsonserializer-in-a-jsonconverter/76705937#76705937
	/// </remarks>
	public abstract class TrakitConverter<T> : JsonConverter<T> {
		/// <summary>
		/// 
		/// </summary>
		[ThreadStatic]
		static bool _isReading;
		/// <summary>
		/// 
		/// </summary>
		[ThreadStatic]
		static bool _isWriting;

		/// <summary>
		/// 
		/// </summary>
		public override sealed bool CanRead => !_isReading;
		/// <summary>
		/// 
		/// </summary>
		public override sealed bool CanWrite => !_isWriting;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="reader"></param>
		/// <param name="type"></param>
		/// <param name="value"></param>
		/// <param name="existing"></param>
		/// <param name="serializer"></param>
		/// <returns></returns>
		/// <exception cref="InvalidOperationException"></exception>
		public override sealed T ReadJson(
			JsonReader reader,
			Type type,
			T value,
			bool existing,
			JsonSerializer serializer
		) {
			if (_isReading) {
				// Protect against any changes to Newtonsoft that somehow cause concurrent access in the same thread recursively
				throw new InvalidOperationException($"Concurrent read detected on {nameof(TrakitConverter<T>)}");
			}
			_isReading = true;
			try {
				return this.convertFrom(reader, type, value, false, serializer);
			} finally {
				_isReading = false;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="writer"></param>
		/// <param name="value"></param>
		/// <param name="serializer"></param>
		/// <exception cref="InvalidOperationException"></exception>
		public override sealed void WriteJson(
			JsonWriter writer,
			T value,
			JsonSerializer serializer
		) {
			if (_isReading) {
				// Protect against any changes to Newtonsoft that somehow cause concurrent access in the same thread recursively
				throw new InvalidOperationException($"Concurrent write detected on {nameof(TrakitConverter<T>)}");
			}
			_isWriting = true;
			try {
				this.convertTo(writer, value, serializer);
			} finally {
				_isWriting = false;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="reader"></param>
		/// <param name="type"></param>
		/// <param name="value"></param>
		/// <param name="existing"></param>
		/// <param name="serializer"></param>
		/// <returns></returns>
		public virtual T convertFrom(
			JsonReader reader,
			Type type,
			T value,
			bool existing,
			JsonSerializer serializer
		) => serializer.Deserialize<T>(reader);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="writer"></param>
		/// <param name="value"></param>
		/// <param name="serializer"></param>
		public virtual void convertTo(
			JsonWriter writer,
			T value,
			JsonSerializer serializer
		) => serializer.Serialize(writer, value);
	}
}