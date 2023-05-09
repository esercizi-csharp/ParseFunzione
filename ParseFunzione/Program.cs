using System;

namespace ParseFunzione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double m;
            double q;

            Parse("4x+5", out m, out q);
            Console.WriteLine("{0}, {1}", m, q);

            Parse("-4x+125", out m, out q);
            Console.WriteLine("{0}, {1}", m, q);

            Parse("4x5", out m, out q);
            Console.WriteLine("{0}, {1}", m, q);
            
            Console.ReadLine();
        }

        private static void Parse(string s, out double m, out double q)
        {
            // <m>x+<q>  3x+10  3 +10
            string[] parts = s.Split('x');

            if (parts.Length != 2)
                throw new Exception("La funzione non è nel formato corretto");

            m = double.Parse(parts[0]);
            q = double.Parse(parts[1]);
        }
    }
}
