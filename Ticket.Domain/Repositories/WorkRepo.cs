namespace Ticket.Domain.Repositories
{
    public class WorkSpaceRepo(ApplicationDbContext context) : BaseRepo<WorkSpaceEntities>(context)
    {
    }

    public class WorkSpaceMemberRepo(ApplicationDbContext context) : BaseRepo<WorkSpaceMemberEntities>(context)
    {
    }
}
