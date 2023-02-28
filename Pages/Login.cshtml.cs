using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace DisasterAlleviationFoundation.Pages
{
    public class LoginModel : PageModel
    {
        public String loginMessage = "";
       
        public void OnGet()
        {
            //RedirectToPage("register");
        }

        public void OnPost()
        {
            String Username = Request.Form["username"];
            String password = Request.Form["password"];
            String userType = Request.Form["theSelection"];

            try
            {
                using (SqlConnection connection = new SqlConnection(Logic.Users.connectionString))
                {
                    connection.Open();
                    String sql = "SELECT * FROM Users;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //if combo box value is Admin
                                if (userType.Equals("Admin"))
                                {
                                    //zero means false
                                    if (reader.GetString(4).Equals("true"))
                                    {
                                        if (Username.Equals(reader.GetString(2)) && password.Equals(reader.GetString(3)) && reader.GetString(4).Equals("true"))
                                        {
                                            loginMessage = "Successfully logged in";
                                            Logic.Users.setUsername(Username);
                                            //setting loggedInCorrectly to true to confirm user logged in
                                            Logic.Users.LoggedInCorrectly = true;
                                            Logic.Users.isAdmin = true;
                                            //redirecting to login page
                                            Response.Redirect("adminHome");
                                        }
                                       
                                    }
                                    else
                                    {
                                        if (Username.Equals(reader.GetString(2)) && password.Equals(reader.GetString(3)))
                                        {
                                            
                                            loginMessage = "Successfully logged in";
                                            Logic.Users.setUsername(Username);
                                            //setting loggedInCorrectly to true to confirm user logged in
                                            Logic.Users.LoggedInCorrectly = true;
                                            Logic.Users.isAdmin = false;
                                            //redirecting to login page
                                            Response.Redirect("Home");

                                        }
                                        
                                    }
                                }
                                else
                                {
                                    if (Username.Equals(reader.GetString(2)) && password.Equals(reader.GetString(3)))
                                    {

                                        loginMessage = "Successfully logged in";
                                        Logic.Users.setUsername(Username);
                                        //setting loggedInCorrectly to true to confirm user logged in
                                        Logic.Users.LoggedInCorrectly = true;
                                        Logic.Users.isAdmin = false;
                                        //redirecting to login page
                                        Response.Redirect("Home");

                                    }

                                }

                               
                               
                            }
                        }

                        Logic.Users.Message = "Credentials invalid";
                    }
                }

            }
            catch (Exception fur)
            {
                Logic.Users.Message = fur.Message;
                Console.WriteLine("{0}", fur.Message);
            }
        }
    }

}
