using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08102020NetFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Hello IT Step");
            Console.WriteLine("Вітаємо в академії ШАГ");

            Console.Write("a=");
            //double a = double.Parse(Console.ReadLine());
            double a;
            bool f = double.TryParse(Console.ReadLine(), out a);
            if (f)
            {
                Console.Write("b=");
                double b = double.Parse(Console.ReadLine());

                double c = a + b;
                Console.WriteLine("a+b" + c);
                Console.WriteLine(a + "+" + b + "=" + c);
                Console.WriteLine("{0}+{1}+{2}", a, b, c);
                Console.WriteLine("{0:f3}+{1}+{2}", a, b, c);
                Console.WriteLine("{0,10:f3}+{1}+{2}", a, b, c);
                Console.WriteLine("{0,10:c3}+{1}+{2}", a, b, c);
                Console.WriteLine($"{a,10:f3}+{b,10:f3}={c,10:f3}");
                Console.WriteLine($"{a,-10:c3}+{b}={c}");
            }
            else Console.WriteLine("Format error A");

            int k = 123;
            Console.WriteLine($"k=|{k,-10:d8}|");


            //string str = "Вітаємо в академії ШАГ";
            ////  str = Console.ReadLine();
            //Console.WriteLine(str);

            //int a = 123;
            //Console.WriteLine(a);
            //Console.WriteLine(a.ToString());
            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine(Int32.MaxValue);

            //byte b = 255;
            //Console.WriteLine(b);
            //sbyte sb = -128; // -128...127
            //Console.WriteLine(sb);

            //Int64 dd;
            //UInt64 dd2;

            //float fl = 9.99f; //(float)9.99;
            //Console.WriteLine(fl);

            //double q = 28.996;
            //Console.WriteLine(q);

            //decimal dec = 10.254m; // money (для грошових величин)
            //Console.WriteLine(dec);

            //bool kk = true;
            //var kk2 = true; // автоматично ініціалізує

            Console.ReadKey(); // затримка консолі
        }
    }
}
