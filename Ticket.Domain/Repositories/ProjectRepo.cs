namespace Ticket.Domain.Repositories
{
    public class ProjectRepo(ApplicationDbContext context) : BaseRepo<ProjectEntities>(context)
    {
    }

    public class ProjectMemberRepo(ApplicationDbContext context) : BaseRepo<ProjectMemberEntities>(context)
    {
    }

    public class ProjectTaskRepo(ApplicationDbContext context) : BaseRepo<ProjectTaskEntities>(context)
    {
    }

    public class ProjectSubTaskRepo(ApplicationDbContext context) : BaseRepo<ProjectSubTaskEntities>(context)
    {
    }
}
