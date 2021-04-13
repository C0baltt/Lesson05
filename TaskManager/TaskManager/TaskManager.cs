using System;

namespace TaskManager
{
    class TaskManager
    {
        static void Main(string[] args)
        {
            Person tom = new Person();
            tom.GetInfo();      // Имя: Возраст: 0

            tom.name = "Tom";
            tom.age = 34;
            tom.GetInfo();  // Имя: Tom Возраст: 34
            Console.ReadKey();
        }
    }

    class Person
    {
        public string name; // имя
        public int age = 18;     // возраст

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
    }

   
    public class WeeklyTask
    {
        private static int counter = 0;
        string nameOfTask = "New task";
        DateTime taskDate = DateTime.Now;

        public WeeklyTask()
        {

        }

        public void CreateWeeklyTask(counter)
        {
            counter 
        }
    }
}
