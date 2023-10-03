namespace blogpessoal.Security
{
    public class Settings
    {
        private static string secret = "2ca9b9ce630a95d31f186004a8c9d2de8c9007381c53db73663807e3d8e7ad59";

        public static string Secret { get => secret; set => secret = value; }
    }
}
