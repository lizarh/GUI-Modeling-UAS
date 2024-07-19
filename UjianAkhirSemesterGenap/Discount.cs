using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UjianAkhirSemesterGenap
{
    internal class Discount
    {
        private int jumlah;
        public Discount(int jumlah) {
            this.jumlah = jumlah;
        }

        public int diskon()
        {
            int result = 0;

            if(this.jumlah >= 11 || this.jumlah >= 25)
            {
                result = 2;
            }
            else if(this.jumlah >= 26 || this.jumlah >= 50)
            {
                result = 5;
            }else if(this.jumlah >= 51 || this.jumlah >= 100)
            {
                result = 10;
            }else if(this.jumlah >= 101 || this.jumlah >= 150)
            {
                result = 15;
            }else if(this.jumlah > 150)
            {
                result = 25;
            }
            else
            {
                result = 0;
            }

            return result;
        }
    }
}
