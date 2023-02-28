using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisasterAlleviationFoundation.Logic
{
    public class Users
    {
        private static String Username;
        public static String connectionString = "Server=tcp:nigelserver.database.windows.net,1433;Initial Catalog=disaster;Persist Security Info=False;User ID=nigel;Password=85235180Tnc;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public static void setUsername(String username)
        {
            Username = username;
        }
        public static String getUsername()
        {
            return Username;
        }
        public Users() { }
        public static String Message = "";
        public static Boolean LoggedInCorrectly = false;
        public static Boolean isAdmin = false;
        public static String NotLoggedInCorrectlyMessage = "Please Log In or create an Account";
    }
}
