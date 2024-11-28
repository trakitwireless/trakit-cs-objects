using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// The base class used to define commands for accessing and manipulating all <see cref="Component">Trak-iT API Objects</see>.
	/// </summary>
	/// <typeparam name="TClient">.NET class used to communicate over the Internet.</typeparam>
	public abstract class TrakitObjectCommander<TClient> : TrakitCommander<TClient> where TClient : IDisposable {
		/// <summary>
		/// Details of the <see cref="User"/> or <see cref="Machine"/> who is connected to the underlying Trak-iT API service.
		/// </summary>
		public RespSelfGet Self { get; protected set; }

		#region Commands - Self
		/// <summary>
		/// Requests the details of the <see cref="User"/> or <see cref="Machine"/> currently identified.
		/// </summary>
		/// <returns></returns>
		public async Task<RespSelfGet> GetSelfDetails() {
			var response = await this.Command<RespSelfGet>(new ReqSelfGet());
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

		/// <summary>
		/// Sends a login command, and if successful, saves the <see cref="RespSelfGet.ghostId"/>
		/// as the authentication mechanism for all further requests.
		/// </summary>
		/// <param name="username">Your email address.</param>
		/// <param name="password">Your password.</param>
		/// <param name="userAgent">Optional string to identify this software.</param>
		/// <returns>The <see cref="RespSelfGet"/>, which contains a <see cref="SelfUser"/> when successful.</returns>
		public async Task<RespSelfGet> Login(string username, string password, string userAgent = default) {
			this.Self = await this.Command<RespSelfGet>(new ReqSelfLogin() {
				username = username,
				password = password,
				userAgent = userAgent,
			});
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
		/// Allows a <see cref="User"/> to update their own <see cref="Contact"/>. 
		/// If your <see cref="User"/> has no associated <see cref="Contact"/>, you will receive a <see cref="ErrorCode.contactNotFound">Contact not found</see> error.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="notes"></param>
		/// <param name="otherNames"></param>
		/// <param name="emails"></param>
		/// <param name="phones"></param>
		/// <param name="addresses"></param>
		/// <param name="urls"></param>
		/// <param name="dates"></param>
		/// <param name="options"></param>
		/// <param name="roles"></param>
		/// <param name="pictures"></param>
		/// <returns></returns>
		public Task<Response> UpdateContact(
			string name,
			string notes,
			Dictionary<string, string> otherNames,
			Dictionary<string, string> emails,
			Dictionary<string, ulong?> phones,
			Dictionary<string, string> addresses,
			Dictionary<string, Uri> urls,
			Dictionary<string, DateTime?> dates,
			Dictionary<string, string> options,
			List<string> roles,
			List<ulong> pictures
		) => this.Command<Response>(new ReqSelfContact() {
			contact = new ParamSelfContactMerge() {
				name = name,
				notes = notes,
				otherNames = otherNames,
				emails = emails,
				phones = phones,
				addresses = addresses,
				urls = urls,
				dates = dates,
				options = options,
				roles = roles,
				pictures = pictures,
			},
		});
		/// <summary>
		/// Allows a session <see cref="User"/> to change their own password.
		/// </summary>
		/// <param name="oldPassword">Your current password, as verification that you are the account owner.</param>
		/// <param name="newPassword">Your new password must conform to your company's <see cref="PasswordPolicy"/>.</param>
		/// <returns></returns>
		public Task<RespSelfPasswordMerge> UpdatePassword(
			string oldPassword,
			string newPassword
		) => this.Command<RespSelfPasswordMerge>(new ReqSelfPassword() {
			current = oldPassword,
			password = newPassword,
		});
		/// <summary>
		/// Allows a <see cref="User"/> to change their own preferences.
		/// </summary>
		/// <param name="language"></param>
		/// <param name="timezone"></param>
		/// <param name="notify"></param>
		/// <param name="formats"></param>
		/// <param name="measurements"></param>
		/// <param name="options"></param>
		/// <returns></returns>
		public Task<Response> UpdatePreferences(
			string language,
			TimeZoneInfo timezone,
			List<UserNotifications> notify,
			Dictionary<string, string> formats,
			Dictionary<string, SystemsOfUnits?> measurements,
			Dictionary<string, string> options
		) => this.Command<Response>(new ReqSelfPreferences() {
			language = language,
			timezone = timezone,
			notify = notify,
			formats = formats,
			measurements = measurements,
			options = options,
		});
		#endregion Commands - Self
	}
}