namespace Ticket.Domain.Entities
{
    /// <summary>
    /// Thực thể nhiệm vụ dự án
    /// </summary>
    [Table("work_ProjectTasks")]
    public class ProjectTaskEntities : BaseEntity<string>
    {
        /// <summary>
        /// Id thành viên đảm nhận
        /// </summary>
        public List<string> MemberIds { get; set; }

        /// <summary>
        /// Id dự án
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// Nội dung nhiệm vụ
        /// </summary>
        public string TaskContent { get; set; }

        /// <summary>
        /// Trạng thái
        /// </summary>
        public ProjectTaskStatusEnums MemberType { get; set; } = ProjectTaskStatusEnums.Pending;

        /// <summary>
        /// Độ ưu tiên
        /// </summary>
        public ProjectTaskPriorityEnums? Priority { get; set; }

        /// <summary>
        /// Thời gian kết thúc
        /// </summary>
        public DateTime? EstimateTime { get; set; }
    }
}
