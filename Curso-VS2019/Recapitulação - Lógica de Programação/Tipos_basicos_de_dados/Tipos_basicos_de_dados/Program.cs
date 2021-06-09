using System;

namespace Tipos_basicos_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            //SByte mesma função de sbyte, porém,
            //pertence ao namespace system do .net;
            sbyte x = 100;
            byte n1 = 126;// 0 a 255, no signed.
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';//char pode ser utilizado por meio do unicode
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria Joana";
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;
            int n7 = int.MinValue;
            int n8 = int.MaxValue;
            sbyte n9 = sbyte.MinValue;
            sbyte n10 = sbyte.MaxValue;
            decimal n11 = decimal.MaxValue;
            
            Console.WriteLine(x);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(n7);
            Console.WriteLine(n8);
            Console.WriteLine(n9);
            Console.WriteLine(n10);
            Console.WriteLine(n11);
        }
    }
}
