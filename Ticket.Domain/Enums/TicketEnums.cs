namespace Ticket.Domain.Enums
{
    public enum TicketEnums
    {
        [EnumMember(Value = "Yêu cầu")]
        Init = 0,

        [EnumMember(Value = "Chấp nhận")]
        Accept = 1,

        [EnumMember(Value = "Từ chối")]
        Decine = 2,

        [EnumMember(Value = "Hủy")]
        Cancel = 3,

        [EnumMember(Value = "Hoàn thành")]
        Complete = 4
    }
}
