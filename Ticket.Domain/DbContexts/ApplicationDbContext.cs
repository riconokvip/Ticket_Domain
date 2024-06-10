namespace Ticket.Domain.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserEntities>().HasIndex(u => u.Id).IsUnique();
            builder.Entity<UserTokenEntities>().HasIndex(u => u.Id).IsUnique();
            builder.Entity<UserPermissionEntities>().HasIndex(u => u.Id).IsUnique();

            builder.Entity<TicketEntities>().HasIndex(u => u.Id).IsUnique();

            builder.Entity<WorkSpaceEntities>().HasIndex(u => u.Id).IsUnique();
            builder.Entity<WorkSpaceMemberEntities>().HasIndex(u => u.Id).IsUnique();

            builder.Entity<ProjectEntities>().HasIndex(u => u.Id).IsUnique();
            builder.Entity<ProjectMemberEntities>().HasIndex(u => u.Id).IsUnique();
            builder.Entity<ProjectTaskEntities>().HasIndex(u => u.Id).IsUnique();
            builder.Entity<ProjectSubTaskEntities>().HasIndex(u => u.Id).IsUnique();
        }

        public virtual DbSet<UserEntities> Users { get; set; }
        public virtual DbSet<UserTokenEntities> UserTokens { get; set; }
        public virtual DbSet<UserPermissionEntities> UserPermissions { get; set; }

        public virtual DbSet<TicketEntities> Tickets { get; set; }

        public virtual DbSet<WorkSpaceEntities> WorkSpaces { get; set; }
        public virtual DbSet<WorkSpaceMemberEntities> WorkSpaceMembers { get; set; }

        public virtual DbSet<ProjectEntities> Projects { get; set; }
        public virtual DbSet<ProjectMemberEntities> ProjectMembers { get; set; }
        public virtual DbSet<ProjectTaskEntities> ProjectTasks { get; set; }
        public virtual DbSet<ProjectSubTaskEntities> ProjectSubTasks { get; set; }
    }
}
