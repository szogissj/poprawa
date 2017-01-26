using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   abstract class Pojazd : IKoszt
    {
      
       public string marka;
        public string model;
        public double cenaZaDzien;
       
       
        public override void ObliczKoszt;
       
         public Pojazd(string marka, string model, double cenaZaDzien) 
         {
            this.marka = marka;
            this.model = model;
            this.cenaZaDzien = cenaZaDzien;
        }
   
      
   }
   

}
