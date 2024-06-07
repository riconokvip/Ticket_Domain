namespace Ticket.Domain.Entities
{
    /// <summary>
    /// Thực thể thành viên trong nhóm công việc
    /// </summary>
    [Table("work_WorkSpaceMembers")]
    public class WorkSpaceMemberEntities : BaseEntity<string>
    {
        /// <summary>
        /// Id thành viên
        /// </summary>
        public string MemberId { get; set; }

        /// <summary>
        /// Id nhóm công việc
        /// </summary>
        public string WorkSpaceId { get; set; }

        /// <summary>
        /// Loại thành viên
        /// </summary>
        public WorkSpaceMemberEnums MemberType { get; set; } = WorkSpaceMemberEnums.Member;
    }
}
