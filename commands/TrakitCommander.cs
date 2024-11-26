using System;
using System.Threading.Tasks;
using Trakit.Objects;
using Trakit.Tools;

namespace Trakit.Commands {
	/// <summary>
	/// The base class used to help define interaction with all Trak-iT API services.
	/// </summary>
	/// <typeparam name="TClient">.NET class used to communicate over the Internet.</typeparam>
	public abstract class TrakitCommander<TClient> where TClient : IDisposable {
		/// <summary>
		/// <see cref="Uri"/> of the underlying Trak-iT API service.
		/// </summary>
		public Uri BaseAddress { get; protected set; }
		/// <summary>
		/// Helps to serialize (and deserialize) content when transmitted between this client and the underlying Trak-iT API service.
		/// </summary>
		public readonly TrakitSerializer Serializer = new TrakitSerializer();
		/// <summary>
		/// The underlying client making requests to the Trak-iT API service.
		/// </summary>
		public virtual TClient Client { get; protected set; }

		#region Authorization
		// saved API credentials when using a service account
		protected Machine _machine;
		// saved session identifier when using a user account
		protected Guid _sessionId;
		/// <summary>
		/// Saves the authentication mechanism as a <see cref="Machine"/>.
		/// </summary>
		/// <param name="machine"></param>
		public void SetAuth(Machine machine) {
			this.SetAuth();
			_machine = machine;
		}
		/// <summary>
		/// Saves the authentication mechanism as a <see cref="Session.id"/>.
		/// </summary>
		/// <param name="sessionId"></param>
		public void SetAuth(Guid sessionId) {
			this.SetAuth();
			_sessionId = sessionId;
		}
		/// <summary>
		/// Unsets the authentication mechanism so that requests are sent without any.
		/// </summary>
		public void SetAuth() {
			_machine = default;
			_sessionId = default;
		}
		#endregion Authorization

		/// <summary>
		/// Sends a command to the underlying service, and returns a <see cref="Task"/> that completes when a reply is received.
		/// </summary>
		/// <typeparam name="TResponse"></typeparam>
		/// <param name="request"></param>
		/// <returns></returns>
		public abstract Task<TResponse> Command<TResponse>(Request request);
	}
}