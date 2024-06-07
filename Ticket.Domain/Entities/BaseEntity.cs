namespace Ticket.Domain.Entities
{
    public class BaseEntity<T> : BaseAudit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public T Id { get; set; }
    }

    public class BaseAudit
    {
        /// <summary>
        /// Thời gian tạo
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Người tạo
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Thời gian cập nhật
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Người cập nhật
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Trạng thái đã xóa
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
