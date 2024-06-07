namespace Ticket.Domain.Entities
{
    /// <summary>
    /// Thực thể phân quyền người dùng trong hệ thống
    /// </summary>
    [Table("user_UserPermissions")]
    public class UserPermissionEntities : BaseEntity<string>
    {
        /// <summary>
        /// Quyền
        /// </summary>
        public PermissionEnums Permission { get; set; }

        /// <summary>
        /// Tài nguyên
        /// </summary>
        public ResourceEnums Resource { get; set; }

        /// <summary>
        /// Id người dùng
        /// </summary>
        public string UserId { get; set; }
    }
}
