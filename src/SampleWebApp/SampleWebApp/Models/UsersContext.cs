namespace SampleWebApp.Models
{
	using System.Data.Entity;

	public class UsersContext : DbContext
	{
		public UsersContext()
			: base("DefaultConnection")
		{
		}

		public DbSet<UserProfile> UserProfiles { get; set; }

		#region Added Code

		public DbSet<Membership> Membership { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<OAuthMembership> OAuthMembership { get; set; }

		public DbSet<TwitterExtraData> TwitterData { get; set; }
		public DbSet<GoogleExtraData> GoogleData { get; set; }
		public DbSet<FacebookExtraData> FacebookData { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Membership>()
				.HasMany<Role>(r => r.Roles)
				.WithMany(u => u.Members)
				.Map(m =>
				{
					m.ToTable("webpages_UsersInRoles");
					m.MapLeftKey("UserId");
					m.MapRightKey("RoleId");
				});
		}

		#endregion
	}
}