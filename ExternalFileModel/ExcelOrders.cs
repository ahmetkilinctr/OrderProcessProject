using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZorluKartela.Models {
    public class ExcelOrders {

        public int? KARTELAID { get; set; }
        public string SUPPLIERNAME { get; set; }
        public string SHOPNAME { get; set; }
        public int COUNT { get; set; }
        public DateTime INSERTDATE { get; set; }
        public Boolean ISACTIVE { get; set; }
        public DateTime UPDATEDATE { get; set; }
        public int REMAINCOUNT { get; set; }
        public int ORDERSTATE { get; set; }
        public int SHOPID { get; set; }
        public int SUPPLIERID { get; set; }
        public DateTime ORDERDATE { get; set; }
        public DateTime ORDERHOUR { get; set; }
        public DateTime ORDERTIME { get; set; }
        public string MAGAZAADI { get; set; }
        public string TEDARIKCIADI { get; set; }
        public string URUNADI { get; set; }
        public string URUNKODU { get; set; }
        public string URUNGRUBU { get; set; }
        public string KARTELADI { get; set; }
        public string SHOPCODE { get; set; }
        public string SUPPLIERCODE { get; set; }

    }
}
