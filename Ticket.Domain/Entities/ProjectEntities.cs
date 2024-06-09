namespace Ticket.Domain.Entities
{
    /// <summary>
    /// Thực thể dự án
    /// </summary>
    [Table("work_Projects")]
    public class ProjectEntities : BaseEntity<string>
    {
        /// <summary>
        /// Tên dự án
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        /// Id nhóm công việc
        /// </summary>
        public string WorkSpaceId { get; set; }

        /// <summary>
        /// Độ ưu tiên dự án
        /// </summary>
        public ProjectTaskPriorityEnums? ProjectPriority { get; set; }

        /// <summary>
        /// Thời gian kết thúc
        /// </summary>
        public DateTime? EstimateTime { get; set; }
    }
}
