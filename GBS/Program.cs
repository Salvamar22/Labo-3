//Hacer una clase padre por ejemplo "cuarto" (vacia)
//3 metodos take, comingIn comingOut
//Crear una interface (llaves) que incluya llaves acite y madera (dos archivos)
//en reservacion estaba numero correlativo y propiedad de tipo cuarto
using System;
using System.Collections.Generic;
namespace GBS
{
    class Program
    {
        static void Main(string[] args)
        {   int option = 0;
            List<Reservacion> reservaciones = new List<Reservacion>();

        do
        {
            Console.WriteLine("\nMenu general.");
            Console.WriteLine("1. Reservar.");
            Console.WriteLine("2. CheckIn.");
            Console.WriteLine("3. CheckOut.");
            Console.WriteLine("4. Mostrar.");
            Console.WriteLine("5. Salir.");
             option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            { 
                
                case 1:
                reservaciones.Add(reservar());
                break;
                case 2: 
                llegar(reservaciones.FindAll(it => it.ocupated == false));
                break;
                case 3: 
                salir(reservaciones.FindAll(it => it.ocupated == true));
                
                break;
                case 4: 
                mostrar(reservaciones);
                break;
                case 5:
                break;
                default: 
                    Console.WriteLine("Intentelo de nuevo");
                    break;

            }
        } while (option != 5);
            
                
        }

        static Reservacion reservar()
        {   
            Cuarto cuartito = null;
            int option = 0;
            string pay = "";
            bool salir = false;
            do
            {
            Console.WriteLine("\nMenu reservaciones.");
            Console.WriteLine("1. Reservar Hotel.");
            Console.WriteLine("2. Reservar Cabaña.");
            Console.WriteLine("3. Reservar Choza.");
            Console.WriteLine("4. Salir.");
            option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1: 
                cuartito = new Hotel();
                goto case Int32.MaxValue;

                case 2: 
                cuartito = new Cabin();
                goto case Int32.MaxValue;
                
                case 3: 
                cuartito = new Hut();
                goto case Int32.MaxValue;

                case Int32.MaxValue:
                pay = payment();
                salir = true;
                break;

                default: 
                    Console.WriteLine("Intentelo de nuevo");
                    break;

            }
                
            } while (salir == false);
            
            return new Reservacion(cuartito, pay, Contador.Valor());
        }
        static void llegar(List<Reservacion> reservaciones)
        {   
            if (reservaciones.Count == 0)
            {
                Console.WriteLine("No hay reservaciones");
                return;
            }
            int correlative = 0;
            Console.WriteLine("\nReservaciones disoponibles");
            reservaciones.ForEach(it => {
                Console.WriteLine(it.Info());
            });
            Console.WriteLine("Ingrese su correlativo de reservacion");
            correlative = Convert.ToInt32(Console.ReadLine());
            Reservacion reservacion =  reservaciones.Find(it => it.correlative == correlative);
            reservacion.ocupated = true;
            
            switch (reservacion.cuarto)
            {
                case Hotel h:
                Console.WriteLine(h.inKey());
                break;

                case Cabin c:
                Console.WriteLine(c.inKey());
                Console.WriteLine(c.inWood());
                break;

                case Hut h:
                
                Console.WriteLine(h.inKey());
                Console.WriteLine(h.inWood());
                Console.WriteLine(h.inOil());
                       
                break;

                default:
                break;
            }

            
            
        }
        static void salir(List<Reservacion> reservaciones)
        {   
            if (reservaciones.Count == 0)
            {
                Console.WriteLine("No hay reservaciones ocupadas");
                return;
            }
            int correlative = 0;
            Console.WriteLine("\nReservaciones ocupadas");
            reservaciones.ForEach(it => {
                
             Console.WriteLine(it.Info());
                        
            });
            Console.WriteLine("Ingrese su correlativo para salir");
            correlative = Convert.ToInt32(Console.ReadLine());
            Reservacion reservacion =  reservaciones.Find(it => it.correlative == correlative);
            reservacion.ocupated = false;

            switch (reservacion.cuarto)
            {
                case Hotel h:
                Console.WriteLine(h.outKey());
                reservaciones.RemoveAll(it => it.correlative == correlative);
             
                break;

                case Cabin c:
                Console.WriteLine(c.outKey());
                reservaciones.RemoveAll(it => it.correlative == correlative);
               
                Console.WriteLine(c.outWood());
                reservaciones.RemoveAll(it => it.correlative == correlative);
            
                break;

                case Hut h:
                Console.WriteLine(h.outKey());
                reservaciones.RemoveAll(it => it.correlative == correlative);
                
                Console.WriteLine(h.outWood());
                reservaciones.RemoveAll(it => it.correlative == correlative);
                
                Console.WriteLine(h.outOil());
                reservaciones.RemoveAll(it => it.correlative == correlative);
                 
                break;

                default:
                break;
            }
        }
        static void mostrar(List<Reservacion> reservaciones)
        {   Console.WriteLine("Mostrando registro");

            reservaciones.ForEach(it => {
                
             Console.WriteLine(it.Info());
                        
            });
        }
        static string payment()
        {   
            string pago="";
            int option=0;
            do
            {   Console.WriteLine("\nMenu de pago");
                Console.WriteLine("1. Pago con tarjeta.");
                Console.WriteLine("2. Pago con efectivo.");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                case 1: 
                pago = "Tarjeta de credito";              
                break;
               
                case 2: 
                pago = "Efectivo";
                break;
 
                    default: 
                    Console.WriteLine("Intentelo de nuevo");
                    break;
                    
                }
                
            } while (option != 1 && option != 2);
            return pago;
        }

    }
}
