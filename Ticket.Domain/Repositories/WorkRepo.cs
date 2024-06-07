namespace Ticket.Domain.Repositories
{
    public class WorkRepo(ApplicationDbContext context) : BaseRepo<WorkEntities>(context)
    {
    }

    public class WorkSpaceRepo(ApplicationDbContext context) : BaseRepo<WorkSpaceEntities>(context)
    {
    }

    public class WorkSpaceMemberRepo(ApplicationDbContext context) : BaseRepo<WorkSpaceMemberEntities>(context)
    {
    }
}
