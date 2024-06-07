namespace Ticket.Domain.Repositories
{
    public class UserRepo(ApplicationDbContext context) : BaseRepo<UserEntities>(context)
    {
    }

    public class UserTokenRepo(ApplicationDbContext context) : BaseRepo<UserTokenEntities>(context)
    {
    }

    public class UserPermissionRepo(ApplicationDbContext context) : BaseRepo<UserPermissionEntities>(context)
    {
    }
}
