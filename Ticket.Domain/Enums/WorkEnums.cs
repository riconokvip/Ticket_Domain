namespace Ticket.Domain.Enums
{
    public enum WorkEnums
    {
        [EnumMember(Value = "Triển khai")]
        Start = 0,

        [EnumMember(Value = "Đang triển khai")]
        Implement = 1,

        [EnumMember(Value = "Hủy")]
        Cancel = 2,

        [EnumMember(Value = "Đánh giá")]
        Review = 3,

        [EnumMember(Value = "Hoàn thành")]
        Complete = 4
    }

    public enum WorkSpaceMemberEnums
    {
        [EnumMember(Value = "Quản lý")]
        Admin = 0,

        [EnumMember(Value = "Thành viên")]
        Member = 1
    }
}
