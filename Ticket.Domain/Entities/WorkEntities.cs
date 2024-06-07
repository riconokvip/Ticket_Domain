namespace Ticket.Domain.Entities
{
    /// <summary>
    /// Thực thể công việc
    /// </summary>
    [Table("work_Works")]
    public class WorkEntities : BaseEntity<string>
    {
        /// <summary>
        /// Id người yêu cầu
        /// </summary>
        public string FromUserId { get; set; }

        /// <summary>
        /// Nội dung yêu cầu
        /// </summary>
        public string WorkContent { get; set; }

        /// <summary>
        /// Trạng thái
        /// </summary>
        public WorkEnums WorkStatus { get; set; } = WorkEnums.Start;
    }
}
