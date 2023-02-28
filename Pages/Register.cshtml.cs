using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace DisasterAlleviationFoundation.Pages
{
    public class RegisterModel : PageModel
    {
        public List<newUser> myUsers = new List<newUser>();
        public newUser user = new newUser();
        public String errorMessage = "";

        
        public void OnGet()
        {
          
        }
        public void OnPost()
        {
            user.Name = Request.Form["name"];
            user.Lname = Request.Form["Lname"];
            user.username = Request.Form["Username"];
            user.Password = Request.Form["password"];

            if (user.Name.Length==0 || user.Lname.Length==0 || user.username.Length == 0 || user.Password.Length == 0)
            {
                errorMessage = "Insert data on all fields";
                return;
            }

            try{
                using (SqlConnection connection = new SqlConnection(Logic.Users.connectionString))
                {
                    connection.Open();
                    String sql = "Insert into Users values(@name,@Lname,@username,@password,@uType);";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@name", user.Name);
                        command.Parameters.AddWithValue("@Lname", user.Lname);
                        command.Parameters.AddWithValue("@username", user.username);
                        command.Parameters.AddWithValue("@password", user.Password);
                        command.Parameters.AddWithValue("@uType", "false");

                        command.ExecuteNonQuery();
                        Response.Redirect("Login");
                        Logic.Users.Message = "Successfully created account!";
                    }
                }

                    }
            catch (Exception er)
            {
                errorMessage = er.Message;
            }
            user.Name = ""; user.Lname = ""; user.username = ""; user.Password = "";
           // Response.Redirect("Login");
        }
    }
    public class newUser
    {
        public String Name;
        public String Lname;
        public String username;
        public String Password;
    }
}
