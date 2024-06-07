namespace Ticket.Domain.Repositories
{
    public class TicketRepo(ApplicationDbContext context) : BaseRepo<TicketEntities>(context)
    {
    }
}
