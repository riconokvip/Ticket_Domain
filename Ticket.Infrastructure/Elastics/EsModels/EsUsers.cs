namespace Ticket.Infrastructure.Elastics
{
    public class EsUsers
    {
        public string Id { get; set; }

        /// <summary>
        /// Tên công việc/ tên đầy đủ
        /// </summary>
        public string WorkName { get; set; }

        /// <summary>
        /// Tài khoản telegram
        /// </summary>
        public string Telegram { get; set; }

        /// <summary>
        /// Tài khoản email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Số điện thoại
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Chức vụ
        /// </summary>
        public string Level { get; set; }

        /// <summary>
        /// Trạng thái khóa khi vi phạm
        /// </summary>
        public bool LockoutViolationEnabled { get; set; }

        /// <summary>
        /// Thời gian tạo
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Danh sách tài nguyên được truy cập
        /// </summary>
        public List<EsUserPermissions> Roles { get; set; }
    }

    public class EsUserPermissions
    {
        public string Id { get; set; }

        /// <summary>
        /// Tài nguyên
        /// </summary>
        public ResourceEnums Resource { get; set; }

        /// <summary>
        /// Quyền
        /// </summary>
        public PermissionEnums Permission { get; set; }

        /// <summary>
        /// Claim
        /// </summary>
        public string Claim { get; set; }

        /// <summary>
        /// Tên quyền
        /// </summary>
        public string PermissionName { get; set; }
    }
}
