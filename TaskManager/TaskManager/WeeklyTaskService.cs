using System;
using TaskManagerNamespace;
using TaskManagerProject;

namespace TaskManagerNamespace
{
    internal class WeeklyTaskService
    {
        private int _counter;
        internal readonly WeeklyTask[] _tasks;

        public WeeklyTaskService()
        {
            _tasks = new WeeklyTask[10];
        }

        public void HandleAddNewTask()
        {
            if (_counter >= 10)
            {
                Console.WriteLine("Out of memory. Delete unnecessary tasks, and try again");
                return;
            }

            Console.WriteLine("Add new task in format: {},{},{}");
            var inputData = Console.ReadLine();
            var task = ParseNewTask(inputData);
            AddNewTask(task);
        }

        public void HandleList()
        {
            for (int i = 0; i < _counter; i++)
            {
                PrintTask(_tasks[i], i);
            }
        }

        public void HandleEdit()
        {
            Console.WriteLine("Input number to edit:");
            var inputNumber = Console.ReadLine();
            var taskNumber = int.Parse(inputNumber);

            Console.WriteLine("Input new task data in format: {},{},{}:");
            var inputTaskData = Console.ReadLine();
            var task = ParseNewTask(inputTaskData);
            UpdateTask(taskNumber - 1, task);

            Message mes;
            mes = PrintMessege;
            mes(taskNumber);
        }

        public delegate void Message(int taskNumber);

        public void HandleFilterByDate()
        {
            Console.WriteLine("Input date:");
            var inputData = Console.ReadLine();
            var date = DateTime.Parse(inputData);

            for (int i = 0; i < _counter; i++)
            {
                var task = _tasks[i];
                if (task.GetDate() >= date)
                {
                    PrintTask(task, i);
                }
            }
        }
        private static void PrintMessege(int taskNumber)
        {
            Console.WriteLine($"Task №{taskNumber - 1} has been updated");
        }

        private void UpdateTask(int taskNumber,WeeklyTask task)
        {
            _tasks[taskNumber - 1] = task;
        }

        private static void PrintTask(WeeklyTask task, int i)
        {
            Console.WriteLine(task.ConvertToString(i));
        }

        public void HandleFilterByPriority()
        {
            Console.WriteLine("Input the priority number:");
            var inputData = Console.ReadLine();

            var priority = Enum.Parse<Priority>(inputData);
            /*static bool IsDefined(Priority, object value)
            {

            }
            if (priority is >= 0 or < (Priority)4)*/

            //bool a = IsDefined(Priority, priority);
            //static bool IsDefined(Priority, object value)

            if (priority is >= 0 or < (Priority)4)
            {
                searchByPriority(priority);
            }
            else
            {
                Console.WriteLine("Invalid priority number! Remember, you must only enter numbers from 0 to 3! \nTry again:");
            }
        }

        public void SearchByPriority(Priority priority)
        {
            bool isThereATask = false;
            for (int i = 0; i < _counter; i++)
            {
                var task = _tasks[i];
                if (task.GetPriority() == priority)
                {
                    PrintTask(task, i);
                    isThereATask = true;
                }
                if (isThereATask == false)
                {
                    Console.WriteLine($"Tasks with priority {priority} not set");
                }
            }
        }

        private WeeklyTask ParseNewTask(string? inputData)
        {
            var parts = inputData?.Split(",");

            if (parts == null || parts.Length < 1 || parts.Length > 4)
            {
                Console.WriteLine("Invalid task format, try again");
                return null;
            }

            return CreateNewTask(parts);
        }

        private WeeklyTask CreateNewTask(string[] parts)
        {
            return parts.Length switch
            {
                1 => CreateTaskWithName(parts),
                2 => CreateTaskWithDate(parts),
                3 => CreateTaskWithDateTime(parts),
                4 => CreateTaskWithDateAndPriority(parts),
                _ => null,
            };
        }

        private WeeklyTask CreateTaskWithName(string[] parts) => new RegularTask(parts[0]);

        private WeeklyTask CreateTaskWithDate(string[] parts)
        {
            var date = DateTime.Parse(parts[1]);
            return new RegularTask(parts[0], date);
        }

        private WeeklyTask CreateTaskWithDateTime(string[] parts)
        {
            var (date, time) = ParseDateTime(parts);
            return new RegularTask(parts[0], date, time);
        }

        private WeeklyTask CreateTaskWithDateAndPriority(string[] parts)
        {
            var (date, time) = ParseDateTime(parts);

            var priority = Enum.Parse<Priority>(parts[3]);
            return new PriorityTask(parts[0], date, time, priority);
        }

        private static (DateTime date, DateTime time) ParseDateTime(string[] parts)
        {
            var date = DateTime.Parse(parts[1]);
            var time = DateTime.Parse(parts[2]);
            return (date, time);
        }

        private void AddNewTask(WeeklyTask task)
        {
            _tasks[_counter] = task;
            _counter++;
            Console.WriteLine("\nTask added successfully!\n");
        }
    }
}
