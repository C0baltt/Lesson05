using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerNamespace
{
    internal class WeeklyTaskService
    {
        private int _counter;
        private readonly WeeklyTask[] _tasks;

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
            ParseNewTask(inputData);
        }


        public void HandleList()
        {
            for (int i = 0; i < _counter; i++)
            {
                var task = _tasks[i];
                Console.WriteLine(task.ConvertToString(i));
            }
        }

        public void HandleEdit()
        {
            Console.WriteLine("Input number to edit:");
            var inputNumber = Console.ReadLine();
            var taskNumber = int.Parse(inputNumber);

            Console.WriteLine("Input new task data:");
            var inputTaskData = Console.ReadLine();
            var task = _tasks[taskNumber - 1];
        }

        public void HandleFilterByDate()
        {
            throw new NotImplementedException();
        }

        public void HandleFilterByPriority()
        {
            throw new NotImplementedException();
        }

        private void ParseNewTask(string? inputData)
        {
            var parts = inputData?.Split(",");

            if (parts == null || parts.Length < 1 || parts.Length > 4)
            {
                Console.WriteLine("Invalid task format, try again");
                return;
            }

            HandleAddNewTask(parts);
        }

        private void HandleAddNewTask(string[] parts)
        {
            switch (parts.Length)
            {
                case 1:
                    AddTaskWithName(parts);
                    break;
                case 2:
                    AddTaskWithDate(parts);
                    break;
                case 3:
                    AddTaskWithDateTime(parts);
                    break;
                case 4:
                    AddTaskWithDateAndPriority(parts);
                    break;
            }
        }
        
        private void AddTaskWithName(string[] parts)
        {
            var task = new WeeklyTask(parts[0]);
            AddNewTask(task);
        }

        private void AddTaskWithDate(string[] parts)
        {
            var date = DateTime.Parse(parts[1]);
            var task = new WeeklyTask(parts[0], date);
            AddNewTask(task);
        }
        
        private void AddTaskWithDateTime(string[] parts)
        {
            var (date, time) = ParseDateTime(parts);
            var task = new WeeklyTask(parts[0], date, time);
            AddNewTask(task);
        }

        private void AddTaskWithDateAndPriority(string[] parts)
        {
            var (date, time) = ParseDateTime(parts);
            
            if (Enum.TryParse<Priority>(parts[3], out var priority))
            {
                var task = new WeeklyTask(parts[0], date, time, priority);
                AddNewTask(task);
            }
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
