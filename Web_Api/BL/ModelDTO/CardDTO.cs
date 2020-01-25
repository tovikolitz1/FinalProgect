using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ModelDTO
{
    class CardDTO
    {
        public int id { get; set; }
        public string describe { get; set; }
        public Nullable<double> freeMonthly { get; set; }
        public Nullable<double> freeWeekly { get; set; }
        public Nullable<double> freeDaily { get; set; }
        public double single { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransitTbl> TransitTbls { get; set; }
    }
}
