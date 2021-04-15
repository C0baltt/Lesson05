using System;
using System.Collections;

namespace Temp
{
    class Temp
    {
        class Account
        {
            public Account(decimal sum, decimal rate)
            {
                if (sum < MinSum) throw new Exception("Недопустимая сумма!");
                Sum = sum; Rate = rate;
            }
            private static decimal minSum = 100; // минимальная допустимая сумма для всех счетов
            public static decimal MinSum
            {
                get { return minSum; }
                set { if (value > 0) minSum = value; }
            }

            public decimal Sum { get; private set; }    // сумма на счете
            public decimal Rate { get; private set; }   // процентная ставка

            // подсчет суммы на счете через определенный период по определенной ставке
            public static decimal GetSum(decimal sum, decimal rate, int period)
            {
                decimal result = sum;
                for (int i = 1; i <= period; i++)
                    result = result + result * rate / 100;
                return result;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter through a space sum, rate and period");

            string inputString = Console.ReadLine(); 
            var splitParameters = inputString.Split(" ");

            decimal s = decimal.TryParse(splitParameters[0], out s);

            splitParameters[1];
            splitParameters[2];

            GetSum(s, rate, period);

            Console.ReadKey();
        }
    }
}
/*using System;
using System.Collections;
 
namespace Collections
{
    class Temp
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(2.3); // заносим в список объект типа double
            list.Add(55); // заносим в список объект типа int
            list.AddRange(new string[] { "Hello", "world" }); // заносим в список строковый массив
 
            // перебор значений
            foreach (object o in list)
            {
                Console.WriteLine(o);
            }
 
            // удаляем первый элемент
            list.RemoveAt(0);
            // переворачиваем список
            list.Reverse();
            // получение элемента по индексу
            Console.WriteLine(list[0]);
            // перебор значений
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
 
            Console.ReadLine();
        }
    }
}*/