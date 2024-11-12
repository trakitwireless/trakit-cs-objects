using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Trakit.Objects;
using Trakit.Tools;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public abstract class Commander {
		/// <summary>
		/// Details of the <see cref="User"/> or <see cref="Machine"/> whose <see cref="Session"/> is connected to the <see cref="client"/>.
		/// </summary>
		public RespSelfDetails self { get; protected set; }
		#region Authorization
		// saved API credentials when using a service account
		protected Machine _machine;
		// saved session identifier when using a user account
		protected Guid _sessionId;
		/// <summary>
		/// Saves the authentication mechanism as a <see cref="Machine"/>.
		/// </summary>
		/// <param name="machine"></param>
		public void setAuth(Machine machine) {
			this.setAuth();
			_machine = machine;
		}
		/// <summary>
		/// Saves the authentication mechanism as a <see cref="Session.id"/>.
		/// </summary>
		/// <param name="sessionId"></param>
		public void setAuth(Guid sessionId) {
			this.setAuth();
			_sessionId = sessionId;
		}
		/// <summary>
		/// Unsets the authentication mechanism so that requests are sent without any.
		/// </summary>
		public void setAuth() {
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
		public abstract Task<TResponse> command<TResponse>(Request request) where TResponse : Response;

		/// <summary>
		/// 
		/// </summary>
		public Serializer serializer { get; private set; } = new Serializer();
		#region Commands - Self
		/// <summary>
		/// Sends a login command, and if successful, saves the <see cref="RespSelfDetails.ghostId"/>
		/// as the authentication mechanism for all further requests.
		/// </summary>
		/// <param name="username">Your email address.</param>
		/// <param name="password">Your password.</param>
		/// <param name="userAgent">Optional string to identify this software.</param>
		/// <returns>The <see cref="RespSelfDetails"/>, which contains a <see cref="SelfUser"/> when successful.</returns>
		public async Task<RespSelfDetails> login(string username, string password, string userAgent = default) {
			var body = new ReqSelfLogin() {
				username = username,
				password = password,
			};
			if (userAgent != default) body.userAgent = userAgent;
			this.self = await this.command<RespSelfDetails>(body);
			if (this.self.errorCode == ErrorCode.success && Guid.TryParse(this.self.ghostId, out Guid sessionId)) {
				this.setAuth(sessionId);
			}
			return this.self;
		}
		/// <summary>
		/// Sends a logout command, and if successful, removes the current session using <see cref="setAuth()"/>.
		/// </summary>
		/// <returns></returns>
		public async Task<RespSelfLogout> logout() {
			var response = await this.command<RespSelfLogout>(new ReqSelfLogout());
			switch (response.errorCode) {
				case ErrorCode.success:
				case ErrorCode.sessionExpired:
					this.setAuth();
					this.self = default;
					break;
			}
			return response;
		}
		/// <summary>
		/// Requests the details of the <see cref="User"/> or <see cref="Machine"/> currently identified.
		/// </summary>
		/// <returns></returns>
		public async Task<RespSelfDetails> getSelfDetails() {
			var response = await this.command<RespSelfDetails>(new ReqSelfDetails());
			switch (response.errorCode) {
				case ErrorCode.success:
				case ErrorCode.passwordExpired:
				case ErrorCode.sessionExpired:
				case ErrorCode.userNotLoggedIn:
					this.self = response;
					break;
				default:
					this.self = default;
					break;
			}
			return this.self;
		}
		#endregion Commands - Self
	}
}