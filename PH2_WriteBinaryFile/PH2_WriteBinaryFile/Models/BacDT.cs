using System;
using System.Collections.Generic;
using System.Text;

namespace PH2_WriteBinaryFile.Models
{
    class BacDT
    {
        public String IDBDT { get; set; }
        public String TenBacDT { get; set; }

        public BacDT()
        {
        }

        public BacDT(string iDBDT, string tenBacDT)
        {
            IDBDT = iDBDT;
            TenBacDT = tenBacDT;
        }

        public override string ToString()
        {
            return String.Format("{0} \t{1}", IDBDT, TenBacDT);
        }
    }
}
