using ApiFlora.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFlora.Class
{
    public class UserCode
    {
        public static List<string> Receive(string Userid,string password)
        {
            string query = "SELECT Customer_code FROM user WHERE username = '"+Userid+ "' AND password = '"+password+ "'";
            return DbClass.GetFromDb(query);
        }
        public static string User(Dictionary<string, string> results,bool secret)
        {
            List<string> key = UserCode.Receive(results["Userid"], results["password"]);
            if (key.Count == 1)
            {
                if (secret == true)
                {
                    return("Right Username or Password");
                }
                else
                {
                    return key.First();
                }
                
            }
            else
            {
                return("Wrong Username or Password");
            }
        }

        
    }
}
