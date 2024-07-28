using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Spide_Tech_App
{
	[Table("Invoice")]
    class Invoice
    {
		[PrimaryKey,Unique, NotNull]
        public int InvoiceId { get; set; }
		
		[NotNull]
        public string Item { get; set; }
		
        [NotNull]
        public double Price{ get; set; }

         [ NotNull]
        public double Storage { get; set; }
		 [ NotNull]
        public double Total { get; set; }
    }
}
