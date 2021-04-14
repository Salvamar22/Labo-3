using System;
namespace GBS
{
     public class Cabin : Cuarto, IWood
    {
        public Cabin()
       {
           
       }
       
         public string inWood()
        {
            return "Se ha entregado madera";
        }
        public string outWood()
        {
            return "Se ha devuelto madera restante";
        }
    }

}