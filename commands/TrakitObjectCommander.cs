using System;
using System.Collections.Generic;
using System.Linq;
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
		/// Sends a login command, and if successful, saves the <see cref="RespSelfGet.ghostId"/>
		/// as the authentication mechanism for all further requests.
		/// </summary>
		/// <param name="username">Your email address.</param>
		/// <param name="password">Your password.</param>
		/// <param name="userAgent">Optional string to identify this software.</param>
		/// <returns>The <see cref="RespSelfGet"/>, which contains a <see cref="SelfUser"/> when successful.</returns>
		public async Task<RespSelfGet> Login(string username, string password, string userAgent = default) {
			var body = new ReqSelfLogin() {
				username = username,
				password = password,
			};
			if (userAgent != default) body.userAgent = userAgent;
			this.Self = await this.Command<RespSelfGet>(body);
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
		#endregion Commands - Self

		#region Commands - Sessions
		/// <summary>
		/// Gets details of the specified <see cref="Session"/>.
		/// </summary>
		/// <typeparam name="TResponse"></typeparam>
		/// <param name="handle"></param>
		/// <returns></returns>
		public Task<RespSessionGet> GetSession<TResponse>(
			string handle
		) => this.Command<RespSessionGet>(new ReqSessionGet() {
			session = new ParamHandle() {
				handle = handle,
			},
		});
		/// <summary>
		/// Gets the list of <see cref="SessionDetails"/>s for the specified <see cref="Company"/>.
		/// </summary>
		/// <param name="companyId"></param>
		/// <param name="includeSuspended"></param>
		/// <param name="includeMessages"></param>
		/// <param name="includeTasks"></param>
		/// <param name="includeDeleted"></param>
		/// <returns></returns>
		public Task<RespSessionListByCompany> ListSessions(
			ulong companyId,
			bool includeSuspended = true,
			bool includeMessages = false,
			bool includeTasks = false,
			bool includeDeleted = false
		) => this.Command<RespSessionListByCompany>(new ReqSessionListByCompany() {
			company = new ParamId() {
				id = companyId
			},
		});
		/// <summary>
		/// Gets the list of <see cref="SessionDetails"/>s for the specified <see cref="User"/>.
		/// </summary>
		/// <param name="companyId"></param>
		/// <param name="includeSuspended"></param>
		/// <param name="includeMessages"></param>
		/// <param name="includeTasks"></param>
		/// <param name="includeDeleted"></param>
		/// <returns></returns>
		public Task<RespSessionListByUser> ListSessions(
			string login,
			bool includeSuspended = true,
			bool includeMessages = false,
			bool includeTasks = false,
			bool includeDeleted = false
		) => this.Command<RespSessionListByUser>(new ReqSessionListByUser() {
			user = new ParamLogin() {
				login = login,
			},
		});
		/// <summary>
		/// Deletes an existing <see cref="Session"/>.
		/// </summary>
		/// <param name="handle"></param>
		/// <returns></returns>
		public Task<RespSessionDelete> DeleteSession(
			string handle
		) => this.Command<RespSessionDelete>(new ReqSessionDelete() {
			session = new ParamHandle() {
				handle = handle,
			},
		});
		#endregion Commands - Sessions
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
			labels = labels?.ToList() ?? new List<string>(),
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
		public Task<RespAssetSuspended> MergeAsset(
			ParamAssetMerge parameters
		) => this.Command<RespAssetSuspended>(new ReqAssetMerge() {
			asset = parameters,
		});

		/// <summary>
		/// Suspends an existing <see cref="Asset"/>.
		/// </summary>
		/// <param name="assetId"></param>
		/// <returns></returns>
		public Task<RespAssetSuspended> SuspendAsset(
			ulong assetId
		) => this.Command<RespAssetSuspended>(new ReqAssetSuspend() {
			asset = new ParamId() {
				id = assetId
			},
		});
		/// <summary>
		/// Reactivates a suspended <see cref="Asset"/>.
		/// </summary>
		/// <param name="assetId"></param>
		/// <returns></returns>
		public Task<RespAssetSuspended> ReactivateAsset(
			ulong assetId
		) => this.Command<RespAssetSuspended>(new ReqAssetReactivate() {
			asset = new ParamId() {
				id = assetId
			},
		});
		/// <summary>
		/// Deletes an existing <see cref="Asset"/>.
		/// </summary>
		/// <param name="assetId"></param>
		/// <returns></returns>
		public Task<RespAssetDeleted> DeleteAsset(
			ulong assetId
		) => this.Command<RespAssetDeleted>(new ReqAssetDelete() {
			asset = new ParamId() {
				id = assetId
			},
		});
		/// <summary>
		/// Restores a deleted <see cref="Asset"/>.
		/// </summary>
		/// <param name="assetId"></param>
		/// <returns></returns>
		public Task<RespAssetDeleted> RestoreAsset(
			ulong assetId
		) => this.Command<RespAssetDeleted>(new ReqAssetRestore() {
			asset = new ParamId() {
				id = assetId
			},
		});
		#endregion Commands - Assets
	}
}