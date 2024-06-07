namespace Ticket.Domain.Entities
{
    /// <summary>
    /// Thực thể yêu cầu
    /// </summary>
    [Table("ticket_Tickets")]
    public class TicketEntities : BaseEntity<string>
    {
        /// <summary>
        /// Id người yêu cầu
        /// </summary>
        public string FromUserId { get; set; }

        /// <summary>
        /// Nội dung yêu cầu
        /// </summary>
        public string TicketContent { get; set; }

        /// <summary>
        /// Id người nhận
        /// </summary>
        public string ToUserId { get; set; }

        /// <summary>
        /// Trạng thái
        /// </summary>
        public TicketEnums TicketStatus { get; set; } = TicketEnums.Init;
    }
}
