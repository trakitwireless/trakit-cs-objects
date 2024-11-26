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

		#region Commands - Users
		/// <summary>
		/// Gets details of the specified <see cref="User"/>.
		/// </summary>
		/// <param name="userId"></param>
		/// <param name="includeDeleted"></param>
		/// <returns></returns>
		public Task<RespUserGet> GetUser<TResponse>(
			ulong userId,
			bool includeDeleted = false
		) => this.Command<RespUserGet>(new ReqUserGet() {
			user = new ParamId() {
				id = userId
			},
			includeDeleted = includeDeleted,
		});

		/// <summary>
		/// Gets the list of <see cref="User"/>s for the specified <see cref="Company"/>.
		/// </summary>
		/// <param name="companyId"></param>
		/// <param name="includeSuspended"></param>
		/// <param name="includeMessages"></param>
		/// <param name="includeTasks"></param>
		/// <param name="includeDeleted"></param>
		/// <returns></returns>
		public Task<RespUserListByCompany> ListUsers(
			ulong companyId,
			bool includeDeleted = false
		) => this.Command<RespUserListByCompany>(new ReqUserListByCompany() {
			company = new ParamId() {
				id = companyId
			},
			includeDeleted = includeDeleted,
		});

		/// <summary>
		/// Creates a new, or updates an existing <see cref="User"/>.
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns></returns>
		public Task<RespUserMerge> MergeUser(
			ParamUserMerge parameters
		) => this.Command<RespUserMerge>(new ReqUserMerge() {
			user = parameters,
		});

		/// <summary>
		/// Deletes an existing <see cref="User"/>.
		/// </summary>
		/// <param name="userId"></param>
		/// <returns></returns>
		public Task<RespUserDelete> DeleteUser(
			ulong userId
		) => this.Command<RespUserDelete>(new ReqUserDelete() {
			user = new ParamId() {
				id = userId
			},
		});
		/// <summary>
		/// Restores a deleted <see cref="User"/>.
		/// </summary>
		/// <param name="userId"></param>
		/// <returns></returns>
		public Task<RespUserDelete> RestoreUser(
			ulong userId
		) => this.Command<RespUserDelete>(new ReqUserRestore() {
			user = new ParamId() {
				id = userId
			},
		});
		#endregion Commands - Users
		#region Commands - Contacts
		/// <summary>
		/// Gets details of the specified <see cref="Contact"/>.
		/// </summary>
		/// <param name="contactId"></param>
		/// <param name="includeDeleted"></param>
		/// <returns></returns>
		public Task<RespContactGet> GetContact<TResponse>(
			ulong contactId,
			bool includeDeleted = false
		) => this.Command<RespContactGet>(new ReqContactGet() {
			contact = new ParamId() {
				id = contactId
			},
			includeDeleted = includeDeleted,
		});

		/// <summary>
		/// Gets the list of <see cref="Contact"/>s for the specified <see cref="Company"/>.
		/// </summary>
		/// <param name="companyId"></param>
		/// <param name="includeSuspended"></param>
		/// <param name="includeMessages"></param>
		/// <param name="includeTasks"></param>
		/// <param name="includeDeleted"></param>
		/// <returns></returns>
		public Task<RespContactListByCompany> ListContacts(
			ulong companyId,
			bool includeDeleted = false
		) => this.Command<RespContactListByCompany>(new ReqContactListByCompany() {
			company = new ParamId() {
				id = companyId
			},
			includeDeleted = includeDeleted,
		});

		/// <summary>
		/// Creates a new, or updates an existing <see cref="Contact"/>.
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns></returns>
		public Task<RespContactMerge> MergeContact(
			ParamContactMerge parameters
		) => this.Command<RespContactMerge>(new ReqContactMerge() {
			contact = parameters,
		});

		/// <summary>
		/// Deletes an existing <see cref="Contact"/>.
		/// </summary>
		/// <param name="contactId"></param>
		/// <returns></returns>
		public Task<RespContactDelete> DeleteContact(
			ulong contactId
		) => this.Command<RespContactDelete>(new ReqContactDelete() {
			contact = new ParamId() {
				id = contactId
			},
		});
		/// <summary>
		/// Restores a deleted <see cref="Contact"/>.
		/// </summary>
		/// <param name="contactId"></param>
		/// <returns></returns>
		public Task<RespContactDelete> RestoreContact(
			ulong contactId
		) => this.Command<RespContactDelete>(new ReqContactRestore() {
			contact = new ParamId() {
				id = contactId
			},
		});
		#endregion Commands - Contacts
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
			ulong companyId
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
			string login
		) => this.Command<RespSessionListByUser>(new ReqSessionListByUser() {
			user = new ParamLogin() {
				login = login,
			},
		});
		/// <summary>
		/// Terminates an existing <see cref="Session"/>.
		/// </summary>
		/// <param name="handle"></param>
		/// <returns></returns>
		public Task<RespSessionDelete> KillSession(
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
		public Task<RespAssetMerge> MergeAsset(
			ParamAssetMerge parameters
		) => this.Command<RespAssetMerge>(new ReqAssetMerge() {
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
		#region Commands - DispatchJobs
		/// <summary>
		/// Gets details of the specified <see cref="DispatchJob"/>.
		/// </summary>
		/// <param name="dispatchJobId"></param>
		/// <param name="includeDeleted"></param>
		/// <returns></returns>
		public Task<RespDispatchJobGet> GetDispatchJob<TResponse>(
			ulong dispatchJobId,
			bool includeDeleted = false
		) => this.Command<RespDispatchJobGet>(new ReqDispatchJobGet() {
			dispatchJob = new ParamId() {
				id = dispatchJobId
			},
			includeDeleted = includeDeleted,
		});

		/// <summary>
		/// Gets the list of <see cref="DispatchJob"/>s for the specified <see cref="Company"/>.
		/// </summary>
		/// <param name="companyId"></param>
		/// <param name="includeSuspended"></param>
		/// <param name="includeMessages"></param>
		/// <param name="includeTasks"></param>
		/// <param name="includeDeleted"></param>
		/// <returns></returns>
		public Task<RespDispatchJobListByCompany> ListDispatchJobs(
			ulong companyId,
			bool includeDeleted = false
		) => this.Command<RespDispatchJobListByCompany>(new ReqDispatchJobListByCompany() {
			company = new ParamId() {
				id = companyId
			},
			includeDeleted = includeDeleted,
		});
		/// <summary>
		/// Gets the list of <see cref="DispatchJob"/>s for the specified <see cref="Company"/> only if the <see cref="DispatchJobGeneral.labels"/> matches all of the given <see cref="Parameters.labels"/>.
		/// </summary>
		/// <param name="companyId"></param>
		/// <param name="labels"></param>
		/// <param name="includeSuspended"></param>
		/// <param name="includeMessages"></param>
		/// <param name="includeTasks"></param>
		/// <param name="includeDeleted"></param>
		/// <returns></returns>
		public Task<RespDispatchJobListByCompanyAndLabels> ListDispatchJobs(
			ulong companyId,
			IEnumerable<string> labels,
			bool includeDeleted = false
		) => this.Command<RespDispatchJobListByCompanyAndLabels>(new ReqDispatchJobListByCompanyAndLabels() {
			company = new ParamId() {
				id = companyId
			},
			labels = labels?.ToList() ?? new List<string>(),
			includeDeleted = includeDeleted,
		});
		/// <summary>
		/// Gets the list of <see cref="DispatchJob"/>s for the specified <see cref="Company"/> only if one of the specified <see cref="DispatchJobGeneral.references"/> fields match.
		/// If no references are specified, it will match any <see cref="DispatchJob"/> with no references.
		/// If a reference value is null, it will match any <see cref="DispatchJob"/> without that reference key.
		/// </summary>
		/// <param name="companyId"></param>
		/// <param name="references"></param>
		/// <param name="includeSuspended"></param>
		/// <param name="includeMessages"></param>
		/// <param name="includeTasks"></param>
		/// <param name="includeDeleted"></param>
		/// <returns></returns>
		public Task<RespDispatchJobListByCompanyAndRefPairs> ListDispatchJobs(
			ulong companyId,
			IDictionary<string, string> references,
			bool includeDeleted = false
		) => this.Command<RespDispatchJobListByCompanyAndRefPairs>(new ReqDispatchJobListByCompanyAndRefPairs() {
			company = new ParamId() {
				id = companyId
			},
			references = references?.ToDictionary(p => p.Key, p => p.Value) ?? new Dictionary<string, string>(),
			includeDeleted = includeDeleted,
		});
		/// <summary>
		/// Gets the list of <see cref="DispatchJob"/>s for the specified <see cref="Asset"/>.
		/// </summary>
		/// <param name="assetId"></param>
		/// <param name="includeSuspended"></param>
		/// <param name="includeMessages"></param>
		/// <param name="includeTasks"></param>
		/// <param name="includeDeleted"></param>
		/// <returns></returns>
		public Task<RespDispatchJobListByAsset> ListDispatchJobsByAsset(
			ulong assetId,
			bool includeDeleted = false
		) => this.Command<RespDispatchJobListByAsset>(new ReqDispatchJobListByAsset() {
			asset = new ParamId() {
				id = assetId
			},
			includeDeleted = includeDeleted,
		});
		/// <summary>
		/// Gets the list of <see cref="DispatchJob"/>s for the specified <see cref="Asset"/> only if one of the specified <see cref="DispatchJobGeneral.references"/> fields match.
		/// If no references are specified, it will match any <see cref="DispatchJob"/> with no references.
		/// If a reference value is null, it will match any <see cref="DispatchJob"/> without that reference key.
		/// </summary>
		/// <param name="assetId"></param>
		/// <param name="references"></param>
		/// <param name="includeSuspended"></param>
		/// <param name="includeMessages"></param>
		/// <param name="includeTasks"></param>
		/// <param name="includeDeleted"></param>
		/// <returns></returns>
		public Task<RespDispatchJobListByAssetAndRefPairs> ListDispatchJobsByAsset(
			ulong assetId,
			IDictionary<string, string> references,
			bool includeDeleted = false
		) => this.Command<RespDispatchJobListByAssetAndRefPairs>(new ReqDispatchJobListByAssetAndRefPairs() {
			asset = new ParamId() {
				id = assetId
			},
			references = references?.ToDictionary(p => p.Key, p => p.Value) ?? new Dictionary<string, string>(),
			includeDeleted = includeDeleted,
		});

		/// <summary>
		/// Creates a new, or updates an existing <see cref="DispatchJob"/>.
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns></returns>
		public Task<RespDispatchJobMerge> MergeDispatchJob(
			ParamDispatchJobMerge parameters
		) => this.Command<RespDispatchJobMerge>(new ReqDispatchJobMerge() {
			dispatchJob = parameters,
		});
		/// <summary>
		/// Completes or modifies an existing <see cref="DispatchJob"/> from a driver's perspective.
		/// This can be used by dispatchers to accomodate thrid-party delivery systems, or correcting errors from drivers.
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns></returns>
		public Task<RespDispatchJobMerge> ChangeDispatchJob(
			ParamDispatchJobChange parameters
		) => this.Command<RespDispatchJobMerge>(new ReqDispatchJobChange() {
			dispatchJob = parameters,
		});
		/// <summary>
		/// Cancels a <see cref="DispatchJob"/>, removing it from the dispatcher's and driver's views.
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns></returns>
		public Task<RespDispatchJobMerge> MergeDispatchJob(
			ParamDispatchJobCancel parameters
		) => this.Command<RespDispatchJobMerge>(new ReqDispatchJobCancel() {
			dispatchJob = parameters,
		});

		/// <summary>
		/// Deletes an existing <see cref="DispatchJob"/>.
		/// </summary>
		/// <param name="dispatchJobId"></param>
		/// <returns></returns>
		public Task<RespDispatchJobDelete> DeleteDispatchJob(
			ulong dispatchJobId
		) => this.Command<RespDispatchJobDelete>(new ReqDispatchJobDelete() {
			dispatchJob = new ParamId() {
				id = dispatchJobId
			},
		});
		/// <summary>
		/// Restores a deleted <see cref="DispatchJob"/>.
		/// </summary>
		/// <param name="dispatchJobId"></param>
		/// <returns></returns>
		public Task<RespDispatchJobDelete> RestoreDispatchJob(
			ulong dispatchJobId
		) => this.Command<RespDispatchJobDelete>(new ReqDispatchJobRestore() {
			dispatchJob = new ParamId() {
				id = dispatchJobId
			},
		});
		#endregion Commands - DispatchJobs
		#region Commands - DispatchTasks
		/// <summary>
		/// Gets details of the specified <see cref="DispatchTask"/>.
		/// </summary>
		/// <param name="dispatchTaskId"></param>
		/// <param name="includeDeleted"></param>
		/// <returns></returns>
		public Task<RespDispatchTaskGet> GetDispatchTask<TResponse>(
			ulong dispatchTaskId,
			bool includeDeleted = false
		) => this.Command<RespDispatchTaskGet>(new ReqDispatchTaskGet() {
			dispatchTask = new ParamId() {
				id = dispatchTaskId
			},
			includeDeleted = includeDeleted,
		});
		/// <summary>
		/// Gets the list of <see cref="DispatchTask"/>s for the specified <see cref="Company"/>.
		/// </summary>
		/// <param name="companyId"></param>
		/// <param name="includeSuspended"></param>
		/// <param name="includeMessages"></param>
		/// <param name="includeTasks"></param>
		/// <param name="includeDeleted"></param>
		/// <returns></returns>
		public Task<RespDispatchTaskListByCompany> ListDispatchTasks(
			ulong companyId,
			bool includeSuspended = true,
			bool includeMessages = false,
			bool includeTasks = false,
			bool includeDeleted = false
		) => this.Command<RespDispatchTaskListByCompany>(new ReqDispatchTaskListByCompany() {
			company = new ParamId() {
				id = companyId
			},
			includeDeleted = includeDeleted,
		});
		/// <summary>
		/// Gets the list of <see cref="DispatchTask"/>s for the specified <see cref="Company"/> only if one of the specified <see cref="DispatchTaskGeneral.references"/> fields match.
		/// If no references are specified, it will match any <see cref="DispatchTask"/> with no references.
		/// If a reference value is null, it will match any <see cref="DispatchTask"/> without that reference key.
		/// </summary>
		/// <param name="companyId"></param>
		/// <param name="references"></param>
		/// <param name="includeSuspended"></param>
		/// <param name="includeMessages"></param>
		/// <param name="includeTasks"></param>
		/// <param name="includeDeleted"></param>
		/// <returns></returns>
		public Task<RespDispatchTaskListByCompanyAndRefPairs> ListDispatchTasks(
			ulong companyId,
			IDictionary<string, string> references,
			bool includeSuspended = true,
			bool includeMessages = false,
			bool includeTasks = false,
			bool includeDeleted = false
		) => this.Command<RespDispatchTaskListByCompanyAndRefPairs>(new ReqDispatchTaskListByCompanyAndRefPairs() {
			company = new ParamId() {
				id = companyId
			},
			references = references?.ToDictionary(p => p.Key, p => p.Value) ?? new Dictionary<string, string>(),
			includeDeleted = includeDeleted,
		});

		/// <summary>
		/// Creates a new, or updates an existing <see cref="DispatchTask"/>.
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns></returns>
		public Task<RespDispatchTaskMerge> MergeDispatchTask(
			ParamDispatchTaskMerge parameters
		) => this.Command<RespDispatchTaskMerge>(new ReqDispatchTaskMerge() {
			dispatchTask = parameters,
		});

		/// <summary>
		/// Deletes an existing <see cref="DispatchTask"/>.
		/// </summary>
		/// <param name="dispatchTaskId"></param>
		/// <returns></returns>
		public Task<RespDispatchTaskDelete> DeleteDispatchTask(
			ulong dispatchTaskId
		) => this.Command<RespDispatchTaskDelete>(new ReqDispatchTaskDelete() {
			dispatchTask = new ParamId() {
				id = dispatchTaskId
			},
		});
		/// <summary>
		/// Restores a deleted <see cref="DispatchTask"/>.
		/// </summary>
		/// <param name="dispatchTaskId"></param>
		/// <returns></returns>
		public Task<RespDispatchTaskDelete> RestoreDispatchTask(
			ulong dispatchTaskId
		) => this.Command<RespDispatchTaskDelete>(new ReqDispatchTaskRestore() {
			dispatchTask = new ParamId() {
				id = dispatchTaskId
			},
		});
		#endregion Commands - DispatchTasks
		#region Commands - Messages
		/// <summary>
		/// Gets details of the specified <see cref="AssetMessage"/>.
		/// </summary>
		/// <param name="assetMessageId"></param>
		/// <param name="includeDeleted"></param>
		/// <returns></returns>
		public Task<RespAssetMessageGet> GetAssetMessage<TResponse>(
			ulong assetMessageId,
			bool includeDeleted = false
		) => this.Command<RespAssetMessageGet>(new ReqAssetMessageGet() {
			assetMessage = new ParamId() {
				id = assetMessageId
			},
			includeDeleted = includeDeleted,
		});

		/// <summary>
		/// Gets the list of <see cref="AssetMessage"/>s for the specified <see cref="Company"/>.
		/// </summary>
		/// <param name="companyId"></param>
		/// <param name="includeSuspended"></param>
		/// <param name="includeMessages"></param>
		/// <param name="includeTasks"></param>
		/// <param name="includeDeleted"></param>
		/// <returns></returns>
		public Task<RespAssetMessageListByCompany> ListAssetMessages(
			ulong companyId,
			bool includeDeleted = false
		) => this.Command<RespAssetMessageListByCompany>(new ReqAssetMessageListByCompany() {
			company = new ParamId() {
				id = companyId
			},
			includeDeleted = includeDeleted,
		});
		/// <summary>
		   /// Gets the list of <see cref="AssetMessage"/>s for the specified <see cref="Asset"/>.
		   /// </summary>
		   /// <param name="assetId"></param>
		   /// <param name="includeSuspended"></param>
		   /// <param name="includeMessages"></param>
		   /// <param name="includeTasks"></param>
		   /// <param name="includeDeleted"></param>
		   /// <returns></returns>
		public Task<RespAssetMessageListByAsset> ListAssetMessagesByAsset(
			ulong assetId,
			bool includeDeleted = false
		) => this.Command<RespAssetMessageListByAsset>(new ReqAssetMessageListByAsset() {
			asset = new ParamId() {
				id = assetId
			},
			includeDeleted = includeDeleted,
		});

		/// <summary>
		/// Creates a new, or updates an existing <see cref="AssetMessage"/>.
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns></returns>
		public Task<RespAssetMessageMerge> MergeAssetMessage(
			ParamAssetMessageMerge parameters
		) => this.Command<RespAssetMessageMerge>(new ReqAssetMessageMerge() {
			assetMessage = parameters,
		});

		/// <summary>
		/// Deletes an existing <see cref="AssetMessage"/>.
		/// </summary>
		/// <param name="assetMessageId"></param>
		/// <returns></returns>
		public Task<RespAssetMessageDelete> DeleteAssetMessage(
			ulong assetMessageId
		) => this.Command<RespAssetMessageDelete>(new ReqAssetMessageDelete() {
			assetMessage = new ParamId() {
				id = assetMessageId
			},
		});
		/// <summary>
		/// Restores a deleted <see cref="AssetMessage"/>.
		/// </summary>
		/// <param name="assetMessageId"></param>
		/// <returns></returns>
		public Task<RespAssetMessageDelete> RestoreAssetMessage(
			ulong assetMessageId
		) => this.Command<RespAssetMessageDelete>(new ReqAssetMessageRestore() {
			assetMessage = new ParamId() {
				id = assetMessageId
			},
		});
		#endregion Commands - AssetMessages
	}
}