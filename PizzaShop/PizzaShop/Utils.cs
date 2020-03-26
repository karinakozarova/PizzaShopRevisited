using System;
using System.IO;

namespace PizzaShop
{
    class Utils
    {
        /// <summary>
        /// get today
        /// </summary>
        /// <returns></returns>
        public static DateTime GetDateTime()
        {
            return DateTime.Now;
        }

        /// <summary>
        ///Validation for email addresses
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Clear the content of a file
        /// </summary>
        /// <param name="filename"> name of the file</param>
        public static void ClearFile(string filename)
        {
            if(filename != null) System.IO.File.WriteAllText(filename, string.Empty);
        }

        /// <summary>
        /// Create empty file
        /// </summary>
        /// <param name="filename"></param>
        public static void CreateEmptyFile(string filename)
        {
            File.Create(filename).Dispose();
        }
    }
}
