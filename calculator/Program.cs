using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("введите первое число");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите второе число");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("1) сложение\n2)вычитание\n3)деление\n4)умножение\n5)процент от числа\n6) квадратный корень ");
            var answ = Console.ReadLine();
            if (answ == "1")
                Console.WriteLine(a + b);
            else if (answ == "2")
                Console.WriteLine(a - b);
            if (answ == "3")
            {
                Console.WriteLine(a / b);
            }

            else if (answ == "4")
                Console.WriteLine(a * b);
            if (answ == "5")
                Console.WriteLine(a / 100 * b);
            else if (answ == "6")
                Console.WriteLine(Math.Sqrt(a));
        }
    }
}
