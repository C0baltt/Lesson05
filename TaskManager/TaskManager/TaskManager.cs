using System;

namespace TaskManager
{
    class TaskManager
    {
        static void Main(string[] args)
        {
            
        }
    }
   
    public class WeeklyTask
    {
        private static int counter = 0;

        string nameOfTask = "New task";
        DateTime taskDate = DateTime.Now;

        public WeeklyTask()
        {
            counter++;
        }

        WeeklyTask(string nameOfTask, DateTime.TryParse(input, out DateTime numberOfArrayElements) )
        {
            
             
        }

        public static bool CreateTask(string inputString)
        {
            DateTime date;
            TimeSpan timeSpan;

            var splitParameters = inputString.Split(" ");

            if (splitParameters.Length == 2)
            {
                new WeeklyTask(splitParameters[0], splitParameters[1]);
            }
            else if (splitParameters.Length == 2)
            {
                new WeeklyTask(splitParameters[0], splitParameters[1], splitParameters[2]);
            }
            else if (splitParameters.Length == 3)
            {
                new WeeklyTask(splitParameters[0], splitParameters[1], splitParameters[2], splitParameters[3]);
            }

            return true;
        }
        
    }
}
