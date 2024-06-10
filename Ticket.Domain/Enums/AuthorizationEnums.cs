namespace Ticket.Domain.Enums
{
    public enum PermissionEnums
    {
        [EnumMember(Value = "Tạo")]
        Create = 0,

        [EnumMember(Value = "Xem danh sách")]
        ReadList = 1,

        [EnumMember(Value = "Xem chi tiết")]
        ReadDetail = 2,

        [EnumMember(Value = "Cập nhật")]
        Update = 3,

        [EnumMember(Value = "Xóa")]
        Delete = 4
    }

    public enum ResourceEnums
    {
        [EnumMember(Value = "Người dùng")]
        User = 0,

        [EnumMember(Value = "Yêu cầu")]
        Ticket = 1,

        [EnumMember(Value = "Nhóm công việc")]
        WorkSpace = 2,

        [EnumMember(Value = "Thành viên nhóm công việc")]
        WorkSpaceMember = 3,

        [EnumMember(Value = "Dự án")]
        Project = 4,

        [EnumMember(Value = "Thành viên dự án")]
        ProjectMember = 5,

        [EnumMember(Value = "Nhiệm vụ")]
        ProjectTask = 6,

        [EnumMember(Value = "Nhiệm vụ con")]
        ProjectSubTask = 7
    }
}
