using System;

namespace homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание № 4");
            Console.WriteLine("Введите сумму вклада: ");
            double sum = Convert.ToDouble(Console.ReadLine());
            if (sum < 100)
            {
                Console.WriteLine("Сумма вклада с начисленными процентами:");
                Console.WriteLine(sum += sum * 0.05);
            }
            else if (sum < 200)
            {
                Console.WriteLine("Сумма вклада с начисленными процентами:");
                Console.WriteLine(sum += sum * 0.07);
            }
            else {
                Console.WriteLine("Сумма вклада с начисленными процентами:");
                Console.WriteLine(sum += sum * 0.1);
            }
        }
    }
}
