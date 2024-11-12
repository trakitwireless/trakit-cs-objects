using System;
using System.Collections.Generic;

namespace Trakit.Objects {
	/// <summary>
	/// The full company object which contains all fields.
	/// </summary>
	public class Company : Compound, IIdUlong, INamed, IAmCompany, IDeletable {
		/// <summary>
		/// 
		/// </summary>
		protected override Component[] Pieces => new Component[] {
			this.general,
			null,	// reserved for future use
			this.directory,
			this.styles,
			this.policies,
			this.reseller,
		};

		/// <summary>
		/// Unique identifier of this Company.
		/// </summary>
		/// <seealso cref="Asset.id" />
		public ulong id => this.general?.id
						?? this.directory?.id
						?? this.policies?.id
						?? this.styles?.id
						?? this.reseller?.id
						?? throw new NullReferenceException("general");
		/// <summary>
		/// The parent organization for this Company.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong parent {
			get => this.general?.parent
				?? this.directory?.parent
				?? this.policies?.parent
				?? this.styles?.parent
				?? this.reseller?.parent
				?? throw new NullReferenceException("general");
			set {
				if (this.general != null) this.general.parent = value;
				if (this.directory != null) this.directory.parent = value;
				if (this.policies != null) this.policies.parent = value;
				if (this.styles != null) this.styles.parent = value;
				if (this.reseller != null) this.reseller.parent = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public CompanyGeneral general { get; set; }
		/// <summary>
		/// The organizational name.
		/// </summary>
		/// <override max-length="100" />
		public string name {
			get => (this.general ?? throw new NullReferenceException("general")).name;
			set => (this.general ?? throw new NullReferenceException("general")).name = value;
		}
		/// <summary>
		/// Notes.
		/// </summary>
		public string notes {
			get => (this.general ?? throw new NullReferenceException("general")).notes;
			set => (this.general ?? throw new NullReferenceException("general")).notes = value;
		}
		/// <summary>
		/// Name/value collections of custom fields used to refer to external systems.
		/// </summary>
		/// <override max-count="10">
		/// <keys max-length="20" />
		/// <values max-length="100" />
		/// </override>
		public Dictionary<string, string> references {
			get => (this.general ?? throw new NullReferenceException("general")).references;
			set => (this.general ?? throw new NullReferenceException("general")).references = value;
		}

		/// <summary>
		/// 
		/// </summary>
		public CompanyDirectory directory { get; set; }
		/// <summary>
		/// The list of Contacts from this and other companies broken down by contact role.
		/// </summary>
		public Dictionary<string, ulong[]> employees {
			get => (this.directory ?? throw new NullReferenceException("directory")).directory;
			set => (this.directory ?? throw new NullReferenceException("directory")).directory = value;
		}

		/// <summary>
		/// 
		/// </summary>
		public CompanyPolicies policies { get; set; }
		/// <summary>
		/// The session lifetime policy.
		/// </summary>
		public SessionPolicy sessionPolicy {
			get => (this.policies ?? throw new NullReferenceException("policies")).sessionPolicy;
			set => (this.policies ?? throw new NullReferenceException("policies")).sessionPolicy = value;
		}
		/// <summary>
		/// The password complexity and expiry policy.
		/// </summary>
		public PasswordPolicy passwordPolicy {
			get => (this.policies ?? throw new NullReferenceException("policies")).passwordPolicy;
			set => (this.policies ?? throw new NullReferenceException("policies")).passwordPolicy = value;
		}

		/// <summary>
		/// 
		/// </summary>
		public CompanyStyles styles { get; set; }
		/// <summary>
		/// The styles for labels added to Assets, Places, and other things.
		/// </summary>
		public Dictionary<string, LabelStyle> labels {
			get => (this.styles ?? throw new NullReferenceException("styles")).labels;
			set => (this.styles ?? throw new NullReferenceException("styles")).labels = value;
		}
		/// <summary>
		/// The styles for status tags added to Assets.
		/// </summary>
		public Dictionary<string, LabelStyle> tags {
			get => (this.styles ?? throw new NullReferenceException("styles")).tags;
			set => (this.styles ?? throw new NullReferenceException("styles")).tags = value;
		}

		/// <summary>
		/// If this company is a reseller, then they have their own theme, support and billing information.
		/// </summary>
		public CompanyReseller reseller;

		// IRequestable
		/// <summary>
		/// The <see cref="id"/> is the key.
		/// </summary>
		/// <returns></returns>
		public override string GetKey() => this.id.ToString();

		// IDeletable
		/// <summary>
		/// Indicates whether this object was deleted.
		/// </summary>
		public bool? deleted => this.general?.deleted;
		/// <summary>
		/// Timestamp from the action that deleted or suspended this object.
		/// </summary>
		public DateTime? since => this.general?.since;
	}
}