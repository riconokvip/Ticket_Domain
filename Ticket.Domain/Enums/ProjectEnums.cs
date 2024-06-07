namespace Ticket.Domain.Enums
{
    public enum ProjectMemberEnums
    {
        [EnumMember(Value = "Quản lý")]
        Admin = 0,

        [EnumMember(Value = "Thành viên chủ chốt")]
        Key = 1,

        [EnumMember(Value = "Thành viên")]
        Member = 2
    }

    public enum ProjectTaskStatusEnums
    {
        [EnumMember(Value = "Đang chờ")]
        Pending = 0,

        [EnumMember(Value = "Đang triển khai")]
        InProcess = 1,

        [EnumMember(Value = "Đánh giá")]
        Review = 2,

        [EnumMember(Value = "Kiểm tra")]
        Testing = 3,

        [EnumMember(Value = "Hoàn thành")]
        Closed = 4
    }

    public enum ProjectTaskPriorityEnums
    {
        [EnumMember(Value = "Thấp")]
        Low = 0,

        [EnumMember(Value = "Bình thường")]
        Normal = 1,

        [EnumMember(Value = "Cao")]
        High = 2,

        [EnumMember(Value = "Gấp")]
        Urgent = 3
    }
}
