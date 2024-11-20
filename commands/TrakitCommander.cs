using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trakit.Objects;
using Trakit.Tools;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public abstract class TrakitCommander {
		/// <summary>
		/// <see cref="Uri"/> of the underlying Trak-iT API service.
		/// </summary>
		public Uri BaseAddress { get; protected set; }
		/// <summary>
		/// 
		/// </summary>
		public readonly TrakitSerializer Serializer = new TrakitSerializer();

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
		public abstract Task<TResponse> Command<TResponse>(Request request);
	}
	
	/// <summary>
	/// 
	/// </summary>
	public abstract class TrakitServiceCommander : TrakitCommander {
		/// <summary>
		/// Details of the <see cref="User"/> or <see cref="Machine"/> who is connected to the underlying Trak-iT API service.
		/// </summary>
		public RespSelfDetails Self { get; protected set; }

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

		#region Commands - Assets
		/// <summary>
		/// Gets details of the specified <see cref="Asset"/>.
		/// </summary>
		/// <param name="assetId"></param>
		/// <param name="includeDeleted"></param>
		/// <returns></returns>
		public Task<RespAssetGet> GetAsset<TResponse>(
			ulong assetId,
			bool includeDeleted = false
		) => this.Command<RespAssetGet>(new ReqAssetGet() {
			asset = new ParamId() {
				id = assetId
			},
			includeDeleted = includeDeleted,
		});
		/// <summary>
		/// Gets the list of <see cref="Asset"/>s for the specified <see cref="Company"/>.
		/// </summary>
		/// <param name="companyId"></param>
		/// <param name="includeSuspended"></param>
		/// <param name="includeMessages"></param>
		/// <param name="includeTasks"></param>
		/// <param name="includeDeleted"></param>
		/// <returns></returns>
		public Task<RespAssetListByCompany> ListAssets(
			ulong companyId,
			bool includeSuspended = true,
			bool includeMessages = false,
			bool includeTasks = false,
			bool includeDeleted = false
		) => this.Command<RespAssetListByCompany>(new ReqAssetListByCompany() {
			company = new ParamId() {
				id = companyId
			},
			includeSuspended = includeSuspended,
			includeDeleted = includeDeleted,
			includeTasks = includeTasks,
			includeMessages = includeMessages,
		});
		/// <summary>
		/// Gets the list of <see cref="Asset"/>s for the specified <see cref="Company"/> only if the <see cref="AssetGeneral.labels"/> matches all of the given <see cref="Parameters.labels"/>.
		/// </summary>
		/// <param name="companyId"></param>
		/// <param name="labels"></param>
		/// <param name="includeSuspended"></param>
		/// <param name="includeMessages"></param>
		/// <param name="includeTasks"></param>
		/// <param name="includeDeleted"></param>
		/// <returns></returns>
		public Task<RespAssetListByCompanyAndLabels> ListAssets(
			ulong companyId,
			IEnumerable<string> labels,
			bool includeSuspended = true,
			bool includeMessages = false,
			bool includeTasks = false,
			bool includeDeleted = false
		) => this.Command<RespAssetListByCompanyAndLabels>(new ReqAssetListByCompanyAndLabels() {
			company = new ParamId() {
				id = companyId
			},
			labels = labels?.ToArray() ?? new string[0],
			includeSuspended = includeSuspended,
			includeDeleted = includeDeleted,
			includeTasks = includeTasks,
			includeMessages = includeMessages,
		});
		/// <summary>
		/// Gets the list of <see cref="Asset"/>s for the specified <see cref="Company"/> only if one of the specified <see cref="AssetGeneral.references"/> fields match.
		/// If no references are specified, it will match any <see cref="Asset"/> with no references.
		/// If a reference value is null, it will match any <see cref="Asset"/> without that reference key.
		/// </summary>
		/// <param name="companyId"></param>
		/// <param name="references"></param>
		/// <param name="includeSuspended"></param>
		/// <param name="includeMessages"></param>
		/// <param name="includeTasks"></param>
		/// <param name="includeDeleted"></param>
		/// <returns></returns>
		public Task<RespAssetListByCompanyAndRefPairs> ListAssets(
			ulong companyId,
			IDictionary<string, string> references,
			bool includeSuspended = true,
			bool includeMessages = false,
			bool includeTasks = false,
			bool includeDeleted = false
		) => this.Command<RespAssetListByCompanyAndRefPairs>(new ReqAssetListByCompanyAndRefPairs() {
			company = new ParamId() {
				id = companyId
			},
			references = references?.ToDictionary(p => p.Key, p => p.Value) ?? new Dictionary<string, string>(),
			includeSuspended = includeSuspended,
			includeDeleted = includeDeleted,
			includeTasks = includeTasks,
			includeMessages = includeMessages,
		});

		/// <summary>
		/// Creates a new, or updates an existing <see cref="Asset"/>.
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns></returns>
		public Task<RespAssetSuspend> MergeAsset(
			ParamAssetMerge parameters
		) => this.Command<RespAssetSuspend>(new ReqAssetMerge() {
			asset = parameters,
		});

		/// <summary>
		/// Suspends an existing <see cref="Asset"/>.
		/// </summary>
		/// <param name="assetId"></param>
		/// <returns></returns>
		public Task<RespAssetSuspend> SuspendAsset(
			ulong assetId
		) => this.Command<RespAssetSuspend>(new ReqAssetSuspend() {
			asset = new ParamId() {
				id = assetId
			},
		});
		/// <summary>
		/// Reactivates a suspended <see cref="Asset"/>.
		/// </summary>
		/// <param name="assetId"></param>
		/// <returns></returns>
		public Task<RespAssetSuspend> ReactivateAsset(
			ulong assetId
		) => this.Command<RespAssetSuspend>(new ReqAssetReactivate() {
			asset = new ParamId() {
				id = assetId
			},
		});
		/// <summary>
		/// Deletes an existing <see cref="Asset"/>.
		/// </summary>
		/// <param name="assetId"></param>
		/// <returns></returns>
		public Task<RespAssetDelete> DeleteAsset(
			ulong assetId
		) => this.Command<RespAssetDelete>(new ReqAssetDelete() {
			asset = new ParamId() {
				id = assetId
			},
		});
		/// <summary>
		/// Restores a deleted <see cref="Asset"/>.
		/// </summary>
		/// <param name="assetId"></param>
		/// <returns></returns>
		public Task<RespAssetDelete> RestoreAsset(
			ulong assetId
		) => this.Command<RespAssetDelete>(new ReqAssetRestore() {
			asset = new ParamId() {
				id = assetId
			},
		});
		#endregion Commands - Assets
	}
}