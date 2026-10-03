namespace EShopping.Services
{
    public static class AppSession
    {
        public static string CurrentUsername { get; set; } = null;
        public static bool IsLoggedIn => !string.IsNullOrEmpty(CurrentUsername);

        public static void Logout()
        {
            CurrentUsername = null;
        }
    }
}