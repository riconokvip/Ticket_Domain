namespace Ticket.Domain.DbContexts
{
    public class DbInitializer
    {
        private readonly ApplicationDbContext _context;

        public DbInitializer(ApplicationDbContext applicationDb)
        {
            _context = applicationDb;
        }

        public void Seeding()
        {
            if (!_context.Users.Any())
            {
                var seeder = Seeder();
                _context.Add(seeder);
                _context.SaveChanges();
            }
        }

        private UserEntities Seeder()
        {
            var admin = new UserEntities
            {
                Id = Guid.NewGuid().ToString(),
                WorkName = "Quản trị viên",
                Email = "admin@okvip.com",
                Level = "Quản trị viên",
                SecurityStamp = new Guid().ToString("D"),
                PasswordHash = "adminokvip".Hash(),
                CreatedAt = ApplicationExtensions.NOW,
                IsAdmin = true
            };
            return admin;
        }
    }
}
