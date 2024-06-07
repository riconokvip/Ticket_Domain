namespace Ticket.Domain.Entities
{
    /// <summary>
    /// Thực thể thành viên dự án
    /// </summary>
    [Table("work_ProjectMembers")]
    public class ProjectMemberEntities : BaseEntity<string>
    {
        /// <summary>
        /// Id thành viên
        /// </summary>
        public string MemberId { get; set; }

        /// <summary>
        /// Id dự án
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// Loại thành viên
        /// </summary>
        public ProjectMemberEnums MemberType { get; set; } = ProjectMemberEnums.Member;
    }
}
