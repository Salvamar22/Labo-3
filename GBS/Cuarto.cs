using System;
namespace GBS
{
    public class Cuarto : IKey
    {
        public string inKey()
        {
            return "Se han entregado las llaves";
        }

        public string outKey()
        {
            return "Se han devuelto las llaves";
        }
    }
}