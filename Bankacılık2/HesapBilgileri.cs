using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankacılık2
{
    internal class HesapBilgileri
    {
        private int hesapToplami = 1500000;

        public int HesapToplami
        {
            get
            {
                return hesapToplami;
            }
            set
            { 
                hesapToplami = value;

            }
        }
    }
}
