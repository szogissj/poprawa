using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Osobowy: Pojazd
    {
        private bool klimatyzacja;
        private bool kombi;
    }
    public Osobowy(string marka, string model, double cenaZaDzien, bool klimatyzacja, bool kombi ) : base ( marka, model, cenaZaDzien, klimatyzacja, kombi)

       {
            }
      public override string ToString() 
            return "Osobowy, marka: " + marka + ", model: "+ model +", cenaZaDzien: " + cenaZaDzien+, "klimatyzacja:" +klimatyzacja+ "kombi" +kombi;
        }

