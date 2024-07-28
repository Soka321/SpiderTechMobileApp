using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Spide_Tech_App
{
	[Table("Bookings")]
    class Bookings
    {
		[PrimaryKey,Unique, NotNull]
        public int BookId { get; set; }
		
		[NotNull]
        public string vinNumber{ get; set; }
		
        [NotNull]
        public string NumberPlate{ get; set; }
		
		
		 [NotNull]
        public string  Type{ get; set; }

         [ NotNull]
        public string Model { get; set; }
		 [ NotNull]
        public string Date { get; set; }
    }
}
