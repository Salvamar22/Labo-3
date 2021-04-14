using System;
namespace GBS
{
    public class Contador
    {
        static int cont = 0;
        //Metodo 
        public static int Valor()
        {
            cont = cont + 1;
            return cont;
        }
    }
}