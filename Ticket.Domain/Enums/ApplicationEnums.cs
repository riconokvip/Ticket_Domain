namespace Ticket.Domain.Enums
{
    public enum ErrorCodes
    {
        /* -- Trạng thái chung -- */
        [EnumMember(Value = "Thành công")]
        SUCCESS = 0,

        [EnumMember(Value = "Lỗi chưa xác định")]
        ERROR = -1,

        /* -- Trạng thái máy -- */
        [EnumMember(Value = "Không được ủy quyền")]
        FORBIDDEN = -2,

        [EnumMember(Value = "Xác thực không thành công")]
        UNAUTHORIZED = -3,

        [EnumMember(Value = "Tham số không hợp lệ")]
        BAD_REQUEST = -4,

        [EnumMember(Value = "Api không tồn tại")]
        NOT_FOUND = -5,

        [EnumMember(Value = "Phương thức không được hỗ trợ")]
        METHOD_NOT_ALLOWED = -6,

        [EnumMember(Value = "Không hỗ trợ loại media type")]
        UNSUPPORTED_MEDIA_TYPE = -7,

        [EnumMember(Value = "Xung đột dữ liệu")]
        CONFLICT = -8,

        [EnumMember(Value = "Truy cập vào tài nguyên bị khóa")]
        LOCKED = -9,

        [EnumMember(Value = "Yêu cầu dữ liệu quá lớn")]
        PAYLOAD_TOO_LARGE = -10,

        [EnumMember(Value = "Quá nhiều yêu cầu")]
        TOO_MANY_REQUEST = -11,

        [EnumMember(Value = "Access token không hợp lệ")]
        UNAUTHENTICATION = -12,

        [EnumMember(Value = "Máy chủ không phản hồi")]
        SERVER_NOT_RESPONSE = -13
    }

    public enum HttpCodes
    {
        OK = 200,

        BAD_REQUEST = 400,

        UNAUTHORIZED = 401,

        FOR_BIDDEN = 403,

        NOT_FOUND = 404,

        METHOD_NOT_ALLOWED = 405,

        CONFLICT = 409,

        PAYLOAD_TOO_LARGE = 413,

        UNSUPPORTED_MEDIA_TYPE = 415,

        LOCKED = 423,

        TOO_MANY_REQUEST = 429,

        INTERNAL_SERVER_ERROR = 500,

        SERVER_NOT_RESPONSE = 504
    }
}
