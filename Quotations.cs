using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Spide_Tech_App
{   
    [Table("Quotation")]
    class Quotations
    {
		
		[PrimaryKey,Unique, NotNull]
        public int QuotationId { get; set; }
		
		
		
		[NotNull]
        public string Part { get; set; }
		
		[NotNull]
        public int NumPart { get; set; }
        [NotNull]
        public string Labour{ get; set; }

         [ NotNull]
        public string Date { get; set; }
    }
}
