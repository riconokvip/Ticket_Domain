namespace Ticket.Domain.Extensions
{
    public static partial class ApplicationExtensions
    {
        /* --- Const extension --- */
        public static DateTime NOW = DateTime.UtcNow;
        public const int IMAGE_LIMIT = 2 * 1024 * 1024;

        /* --- Function extension --- */
        /// <summary>
        /// Hash mật khẩu
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string Hash(this string text)
        {
            return Crypt.HashPassword(text, 10, false);
        }

        /// <summary>
        /// Xác thực mật khẩu
        /// </summary>
        /// <param name="text"></param>
        /// <param name="comparedText"></param>
        /// <returns></returns>
        public static bool Verify(this string text, string comparedText)
        {
            return Crypt.Verify(text, comparedText, false);
        }

        /// <summary>
        /// Generate mã bảo mật
        /// </summary>
        /// <returns></returns>
        public static string SecurityGenerate()
        {
            int length = 10;
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+";
            var random = new Random();
            string password = new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
            return password;
        }
    }
}
