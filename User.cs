using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;


namespace Spide_Tech_App
{
   public  class User
    {
        public int user_id { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string phone_num { get; set; }
        public string password { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string address { get; set; }
        public bool isActive { get; set; }
        public int usertype { get; set; }

    }
}
