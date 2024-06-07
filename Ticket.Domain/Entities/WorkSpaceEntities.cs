namespace Ticket.Domain.Entities
{
    /// <summary>
    /// Thực thể nhóm công việc
    /// </summary>
    [Table("work_WorkSpaces")]
    public class WorkSpaceEntities : BaseEntity<string>
    {
        /// <summary>
        /// Tên không gian công việc
        /// </summary>
        public string WorkSpaceName { get; set; }

        /// <summary>
        /// Màu đại diện
        /// </summary>
        public string WorkSpaceColor { get; set; }
    }
}
