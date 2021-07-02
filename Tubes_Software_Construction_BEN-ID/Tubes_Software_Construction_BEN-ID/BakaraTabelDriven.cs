using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_Software_Construction_BEN_ID
{
    class BakaraTabelDriven
    {
        public enum BBM
        {
            PERTAMAX, SOLAR, PERTALITE, PERTAMAXT
        }
        public static int GetHarga(BBM BBM)
        {
            int[] Harga = { 7500, 6000, 7000, 9000 };
            return Harga[(int)BBM];
        }
    }
}
