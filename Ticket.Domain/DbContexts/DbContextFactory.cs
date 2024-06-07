namespace Ticket.Domain.DbContexts
{
    internal class DbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Server=RICON-ITWEB;Database=Ticket;User ID=tohi_dev;Password=tohi1234;TrustServerCertificate=True;MultipleActiveResultSets=true;");
            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
