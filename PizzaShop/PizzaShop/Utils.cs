using System;

namespace PizzaShop
{
    class Utils
    {
        public static DateTime GetDateTime()
        {
            return DateTime.Now;
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static void ClearFile(string filename)
        {
            System.IO.File.WriteAllText(filename, string.Empty);
        }
    }
}
