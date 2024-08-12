using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZorluKartela.ExternalFiles {
    class ExcelTransfers {

        public int ORDERID { get; set; }
        public string SHIPPERNO { get; set; }
        public string WAYBILLNO { get; set; }
        public int COUNT { get; set; }
        public DateTime TRANSFERDATE { get; set; }
        public DateTime TRANSFERHOUR { get; set; }
        public DateTime TRANSFERTIME { get; set; }
        public DateTime INSERTDATE { get; set; }
        public Boolean ISACTIVE { get; set; }
        public DateTime UPDATEDATE { get; set; }
        public Boolean ISRETURNED { get; set; }
        public Boolean HASRECEIVED { get; set; }
        public string TEDARIKCIADI { get; set; }
        public string MAGAZAADI { get; set; }
        public string KARTELAADI { get; set; }
        public string SHOPCODE { get; set; }
        public string SUPPLIERCODE { get; set; }

    }
}
