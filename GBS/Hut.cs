using System;
namespace GBS
{
    public class Hut : Cuarto, IWood, IOil
    {
        public Hut()
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

        public string inOil()
        {
            return "Se han entregado aceites";
        }

        public string outOil()
        {
            return "Se han devuelto aceites sobrantes";
        }

        
    }

}