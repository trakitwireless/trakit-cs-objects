using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
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
		/// Additional (optional) values added to the query-string of the connection request.
		/// </summary>
		public readonly Dictionary<string, string> Query = new Dictionary<string, string>();
		/// <summary>
		/// Additional (optional) HTTP headers added to the connection request.
		/// </summary>
		public readonly Dictionary<string, string> Headers = new Dictionary<string, string>();

		/// <summary>
		/// Helps to serialize (and deserialize) content when transmitted between this client and the underlying Trak-iT API service.
		/// </summary>
		public readonly TrakitSerializer Serializer = new TrakitSerializer();
		/// <summary>
		/// The underlying client making requests to the Trak-iT API service.
		/// </summary>
		public virtual TClient Client { get; protected set; }

		/// <summary>
		/// Returns the <see cref="BaseAddress"/> with the appropriate <paramref name="path"/>, <see cref="Query"/> values (and session token if applicable).
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		protected UriBuilder CreateBaseUri(string path = null) {
			var endpoint = new UriBuilder(this.BaseAddress);
			endpoint.Path = path ?? "";
			var query = new Dictionary<string, string>(this.Query);
			if (_sessionId != default) {
				query["ghostId"] = _sessionId.ToString();
			}
			if (query.Count > 0) {
				endpoint.Query += "&" + string.Join(
					"&",
					this.Query.Select(p => $"{HttpUtility.UrlEncode(p.Key)}={HttpUtility.UrlEncode(p.Value)}")
				);
			}
			if (endpoint.Query.Length > 1 && endpoint.Query[1] == '&') {
				endpoint.Query = endpoint.Query.Substring(2);
			}
			return endpoint;
		}

		#region Authorization
		// saved API credentials when using a service account
		protected Machine _machine { get; private set; }
		// saved session identifier when using a user account
		protected Guid _sessionId { get; private set; }
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