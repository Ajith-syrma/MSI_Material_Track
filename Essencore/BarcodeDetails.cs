using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MSI
{
    class BarcodeDetails
    {
        //  public int barcodeid { get; set; }
         public string Fg_Name { get; set; }
         public string Material_number { get; set; }
          public string Customer_Material { get; set; }
         public string Description { get; set; }
        //public string ProductNo { get; set; }
        //public string CustomerSerialNo { get; set; }
        //public string PCBSerialNo { get; set; }
        ////public string DateandTime { get; set; }
        ////public string ShiftType { get; set; }
        //public int WeekDetails { get; set; }
        //public string Dublicate { get; set; }

    }

    class UserDetails
    {
        public string emp_id { get; set; }
    }
}
