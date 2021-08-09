using System;

namespace Ejercicio8_Numero_Menor
{
    class Program
    {
        static void Main(string[] args)
        {
            int Resultado = NumeroMenor(1, 2);
            Console.WriteLine("El numero menor es:"+Resultado);
        }
        public static int NumeroMenor(int n1,int n2)
        {
            if (n1<n2)
            {
                return n1;
            }
            else
            {
                return n2;
            }
        }
    }
}
