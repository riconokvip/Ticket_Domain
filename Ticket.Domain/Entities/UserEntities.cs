namespace Ticket.Domain.Entities
{
    /// <summary>
    /// Thực thể người dùng trong hệ thống
    /// </summary>
    [Table("user_Users")]
    public class UserEntities : BaseEntity<string>
    {
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
        /// Quản trị viên
        /// </summary>
        public bool IsAdmin { get; set; } = false;

        /// <summary>
        /// Mã bảo mật
        /// </summary>
        public string SecurityStamp { get; set; }

        /// <summary>
        /// Mật khẩu
        /// </summary>
        public string PasswordHash { get; set; }

        /// <summary>
        /// Số cần kết nối thất bại
        /// </summary>
        public int AccessFailedCount { get; set; } = 0;

        /// <summary>
        /// Trạng thái khóa khi vi phạm
        /// </summary>
        public bool LockoutViolationEnabled { get; set; } = false;

        /// <summary>
        /// Lý do khóa khi vi phạm
        /// </summary>
        public string LockoutViolationReason { get; set; }

        /// <summary>
        /// Thời hạn khóa khi vi phạm
        /// </summary>
        public DateTime? LockoutViolationEnd { get; set; }
    }
}
