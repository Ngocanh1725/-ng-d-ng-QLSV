namespace Ứng_dụng_QLSV
{
    /// <summary>
    /// Lớp static để lưu trữ thông tin của người dùng đang đăng nhập.
    /// </summary>
    public static class CurrentUser
    {
        public static string Username { get; set; }
        public static string Role { get; set; }
        public static string MaSV { get; set; }

        public static void Clear()
        {
            Username = null;
            Role = null;
            MaSV = null;
        }
    }
}

