using System;

namespace funkci
{
    class Program
    {
        class fun
        {
            public int x, y;
            public void vivod()
            {
                Console.WriteLine($"{x}{y}");

            }
            public int summ()
            {
                return x + y;
            }
            public int Max()
            {
                Console.WriteLine("Введите два числа : ");

                x = Convert.ToInt32(Console.ReadLine());

                y = Convert.ToInt32(Console.ReadLine());
                if (x > y)

                {

                    Console.WriteLine("{0} наибольшее число", x);
                    return x;
                }

                else

                {

                    Console.WriteLine("{0} наибольшее число ", y);
                    return y;
                }

            }
        }
    }
    static void Main(string[] args)
    {
       
    }
}
    

