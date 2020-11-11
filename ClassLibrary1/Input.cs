using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Input
    {
        public static int NumeroInt()
        {
            Console.WriteLine("inserisci un numero intero: ");
            int a = int.Parse(Console.ReadLine());
            return a;
        }
        public static double NumeroDouble()
        {
            Console.WriteLine("inserisci un numero decimale: ");
            double a = double.Parse(Console.ReadLine());
            return a;
        }
        public static string String()
        {
            Console.WriteLine("inserisci una stringa: ");
            string a = Convert.ToString(Console.ReadLine());
            return a;
        }
    }
}
