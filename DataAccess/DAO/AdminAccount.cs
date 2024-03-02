using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace DataAccess.DAO
{
    public class AdminAccount
    {
        public static bool IsAdmin(string Username, string Password)
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            string AdUsername = configurationRoot["admin:email"];
            string AdPassword = configurationRoot["admin:password"];
            if (Username == AdUsername && Password == AdPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
