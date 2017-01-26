using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Autobus: Pojazd
    {

        private int liczbamiejsc;

         public Autobus(string marka, string model, double cenaZaDzien, int liczbamiejsc)  
        {
            this.marka = marka;
            this.model = model;
            this.cenaZaDzien = cenaZaDzien;
            this.liczbamiejsc = liczbamiejsc;
        }
         public override string ToString()  
         {
             return "Autobus, marka: " + marka + ", model: " +  model + ", cenaZaDzien: " + cenaZaDzien+ ",liczbamiejsc:" + liczbamiejsc ;
         }

    }
}
