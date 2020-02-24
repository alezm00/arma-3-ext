using System;
using Maca134.Arma.DllExport;

namespace firsttry
{
    public class firsttry
    {
        [ArmaDllExport]
        public static string Invoke(string input, int maxsize)
        {
            return input;
        }
    }
}
