using System;
using System.Diagnostics;
using System.Text;

namespace stringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder();

            str.Append("Hej");
            str.AppendLine();                   // måste göra en appendlinda för att byta linje
            str.Append("Yo");

            Console.WriteLine(str);

            str.Replace("Hej", "Hello");
            Console.WriteLine(str);

            Console.WriteLine(str.Length);
            Console.WriteLine(str[0] + " " + str[1]);

            str.Remove(0, str.Length);

            Console.WriteLine("After removal!");
            Console.WriteLine("--------------");
            Console.WriteLine(str);


            Console.WriteLine("str after clear");
            str.Append("hej");
            str.Clear();

            Console.WriteLine(str);

            Stopwatch sw1 = new Stopwatch();
            sw1.Start();

            string s1 = "";

            for (int i = 0; i < 100000; i++)
            {
                s1 += i;
            }
            sw1.Stop();
            Console.WriteLine("Time string: " + sw1.ElapsedMilliseconds + "ms");

            Stopwatch sw2 = new Stopwatch();

            sw2.Start();
            for (int i = 0; i < 100000; i++)
            {
                str.Append(i);
            }

            sw2.Stop();
            Console.WriteLine("Time for StringBuilder: " + sw2.ElapsedMilliseconds + "ms");


            Console.ReadKey();
        }
    }
}
