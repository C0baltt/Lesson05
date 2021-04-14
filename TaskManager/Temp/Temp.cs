using System;
using System.Collections;

namespace Temp
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

            Console.WriteLine("\n");
            // удаляем первый элемент
            list.RemoveAt(0);
            // переворачиваем список
            list.Reverse();
            // получение элемента по индексу
            Console.WriteLine(list[1]);
            // перебор значений

            Console.WriteLine("\n");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.ReadLine();
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