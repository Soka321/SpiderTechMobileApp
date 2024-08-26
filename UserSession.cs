using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spide_Tech_App
{
    public static class UserSession
    {
        public static int user_id { get; set; }
        public static string email { get; set; }
        public static string name { get; set; }
        public static string surname { get; set; }
        public static string phone_num { get; set; }
        public static string password { get; set; }
        public static DateTime created_at { get; set; }
        public static DateTime updated_at { get; set; }
        public static string address { get; set; }
        public static bool isActive { get; set; }
        public static int userType { get; set; }
    }
}
