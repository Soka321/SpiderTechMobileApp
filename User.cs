using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;


namespace Spide_Tech_App
{
	[Table("User")]
     class User
    {
		[PrimaryKey,Unique, NotNull]
        public int UserId { get; set; }
		
		[NotNull]
        public string UserName { get; set; }
        [NotNull]
        public string UserSurname { get; set; }

         [Unique, NotNull]
        public string UserEmail { get; set; }
		[Unique, NotNull]
        public string UserPassword { get; set; }
[NotNull]
        public int UserContact { get; set; }
      [Unique, NotNull]
         public string UserType { get; set; }

        

    }
}
