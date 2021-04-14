using System;

namespace GBS
{
    public class Reservacion
    {   

        public Cuarto cuarto{ get; set;}

        public string pay{ get; set;}
       
        public int correlative{ get; set;}

        public bool ocupated{ get; set;}


        public Reservacion( Cuarto cuarto, string pay, int correlative )
        {   
            this.cuarto = cuarto;
            this.pay = pay;
            this.correlative = correlative;
            this.ocupated = false;
        }
        public string Info ()
        {
            return $"Cuarto:{cuarto}, Pago:{pay}, Id:{correlative}";
        }

    }
}