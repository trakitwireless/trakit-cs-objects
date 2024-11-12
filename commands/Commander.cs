using System;
using System.Threading.Tasks;
using Trakit.Objects;
using Trakit.Tools;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public abstract class Commander {
		/// <summary>
		/// <see cref="Uri"/> of the Trak-iT API service.
		/// </summary>
		public Uri BaseAddress { get; protected set; }

		/// <summary>
		/// Details of the <see cref="User"/> or <see cref="Machine"/> whose <see cref="Session"/> is connected to the <see cref="client"/>.
		/// </summary>
		public RespSelfDetails Self { get; protected set; }
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
		/// Used to correlate requests and responses.
		/// </summary>
		protected int _reqId;
		/// <summary>
		/// Sends a command to the underlying service, and returns a <see cref="Task"/> that completes when a reply is received.
		/// </summary>
		/// <typeparam name="TResponse"></typeparam>
		/// <param name="request"></param>
		/// <returns></returns>
		/// <exception cref="InvalidOperationException"></exception>
		public abstract Task<TResponse> Command<TResponse>(Request request) where TResponse : Response;

		/// <summary>
		/// 
		/// </summary>
		public Serializer Serializer { get; private set; } = new Serializer();
		#region Commands - Self
		/// <summary>
		/// Sends a login command, and if successful, saves the <see cref="RespSelfDetails.ghostId"/>
		/// as the authentication mechanism for all further requests.
		/// </summary>
		/// <param name="username">Your email address.</param>
		/// <param name="password">Your password.</param>
		/// <param name="userAgent">Optional string to identify this software.</param>
		/// <returns>The <see cref="RespSelfDetails"/>, which contains a <see cref="SelfUser"/> when successful.</returns>
		public async Task<RespSelfDetails> Login(string username, string password, string userAgent = default) {
			var body = new ReqSelfLogin() {
				username = username,
				password = password,
			};
			if (userAgent != default) body.userAgent = userAgent;
			this.Self = await this.Command<RespSelfDetails>(body);
			if (this.Self.errorCode == ErrorCode.success && Guid.TryParse(this.Self.ghostId, out Guid sessionId)) {
				this.SetAuth(sessionId);
			}
			return this.Self;
		}
		/// <summary>
		/// Sends a logout command, and if successful, removes the current session using <see cref="SetAuth()"/>.
		/// </summary>
		/// <returns></returns>
		public async Task<RespSelfLogout> Logout() {
			var response = await this.Command<RespSelfLogout>(new ReqSelfLogout());
			switch (response.errorCode) {
				case ErrorCode.success:
				case ErrorCode.sessionExpired:
					this.SetAuth();
					this.Self = default;
					break;
			}
			return response;
		}
		/// <summary>
		/// Requests the details of the <see cref="User"/> or <see cref="Machine"/> currently identified.
		/// </summary>
		/// <returns></returns>
		public async Task<RespSelfDetails> GetSelfDetails() {
			var response = await this.Command<RespSelfDetails>(new ReqSelfDetails());
			switch (response.errorCode) {
				case ErrorCode.success:
				case ErrorCode.passwordExpired:
				case ErrorCode.sessionExpired:
				case ErrorCode.userNotLoggedIn:
					this.Self = response;
					break;
				default:
					this.Self = default;
					break;
			}
			return this.Self;
		}
		#endregion Commands - Self
	}
}