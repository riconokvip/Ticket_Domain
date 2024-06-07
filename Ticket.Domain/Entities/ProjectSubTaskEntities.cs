namespace Ticket.Domain.Entities
{
    /// <summary>
    /// Thực thể nhiệm vụ con
    /// </summary>
    [Table("work_ProjectSubTasks")]
    public class ProjectSubTaskEntities : BaseEntity<string>
    {
        /// <summary>
        /// Id nhiệm vụ
        /// </summary>
        public string ProjectTaskId { get; set; }

        /// <summary>
        /// Nội dung nhiệm vụ con
        /// </summary>
        public string SubTaskContent { get; set; }

        /// <summary>
        /// Trạng thái hoàn thành
        /// </summary>
        public bool IsCompleted { get; set; }
    }
}
