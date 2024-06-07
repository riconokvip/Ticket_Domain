namespace Ticket.Domain.Enums
{
    public enum PermissionEnums
    {
        [EnumMember(Value = "Tạo")]
        Create = 0,

        [EnumMember(Value = "Xem")]
        Read = 1,

        [EnumMember(Value = "Cập nhật")]
        Update = 2,

        [EnumMember(Value = "Xóa")]
        Delete = 3
    }

    public enum ResourceEnums
    {
        [EnumMember(Value = "Người dùng")]
        User = 0,

        [EnumMember(Value = "Yêu cầu")]
        Ticket = 1,

        [EnumMember(Value = "Công việc")]
        Work = 2,

        [EnumMember(Value = "Nhóm công việc")]
        WorkSpace = 3,

        [EnumMember(Value = "Thành viên nhóm công việc")]
        WorkSpaceMember = 4,

        [EnumMember(Value = "Dự án")]
        Project = 5,

        [EnumMember(Value = "Thành viên dự án")]
        ProjectMember = 6,

        [EnumMember(Value = "Nhiệm vụ")]
        ProjectTask = 7,

        [EnumMember(Value = "Nhiệm vụ con")]
        ProjectSubTask = 8
    }
}
