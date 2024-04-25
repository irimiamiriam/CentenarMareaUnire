using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentenarMareaUnire.DataAccess
{
    public class DataAccess
    {
        public static string GetConnectionPath()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }
        public static string GetUsersPath()
        {
            return ConfigurationManager.AppSettings["UsersPath"];
        }
        public static string GetLectiiPath()
        {
            return ConfigurationManager.AppSettings["LectiiPath"];
        }
    }
}
