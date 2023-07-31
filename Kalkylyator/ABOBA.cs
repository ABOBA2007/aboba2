using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkylyator
{
    internal class ABOBA
    {
        public static bool IsChislo(string Chislo)
        {
            foreach(var item in Chislo)
            {
                if (!(char.IsDigit(item) && item == ','))
                {
                    return false;
                }
            }
            return true;
        }
        private static void raschet(int operacia, double znachenie)
        {
            

        }
    }
}
