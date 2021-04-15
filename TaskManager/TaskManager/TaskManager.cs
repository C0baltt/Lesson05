using System;

namespace TaskManager
{
    class TaskManager
    {

        private static int s_counter;
        private static WeeklyTask[] tasks = new WeeklyTask[10];
        static void Main(string[] args)
        {
            RunInLoop();
            Console.ReadKey();
        }

        private static void RunInLoop()
        {
            string input = null;

            while (input != "exit")
            {
                PrintMenu();

                input = Console.ReadLine();

                if (int.TryParse(input, out var parsedInput))
                {
                    HandleCommand(parsedInput);
                }
                else
                {
                    Console.WriteLine("Invalid command. Remember, you must only enter numbers from 1 to 5! Try again, or type \"exit\" to close app");
                }
            }
        }

        private static void HandleCommand(int parsedInput)
        {
            switch (parsedInput)
            {
                case 1:
                    HandleAddNewTask();
                    break;
                case 2:
                    HandleList();
                    break;
                case 3:
                    HandleEdit();
                    break;
                case 4:
                    HandleFilterByDate();
                    break;
                case 5:
                    HandleFilterByPriority();
                    break;
            }
        }

        private static void PrintMenu()
        {
            Console.WriteLine(@"Choose a command:
1. Add new task
2. List all tasks
3. Edit task
4. Filter by date
5. Filter by priority");
        }

        private static void HandleList()
        {
            throw new NotImplementedException();
        }

        private static void HandleEdit()
        {
            throw new NotImplementedException();
        }

        private static void HandleFilterByDate()
        {
            throw new NotImplementedException();
        }

        private static void HandleFilterByPriority()
        {
            throw new NotImplementedException();
        }

        private static void HandleAddNewTask()
        {
            if (s_counter > 10)
            {
                Console.WriteLine("Out of memory");
            }
            Console.WriteLine("Add new task in format: {},{},{}");
            string inputData = Console.ReadLine();
            var parts = inputData?.Split(",");

            if (parts == null || parts.Length < 1 || parts.Length > 4)
            {
                Console.WriteLine("Invalid task format, try again");
                return;
            }

            switch (parts.Length)
            {
                case 1:
                    if (s_counter < 10)
                    {
                        AddTaskWithName(parts);
                    }
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

        private static void AddTaskWithName(string[] parts)
        {
            var task = new WeeklyTask(parts[0]);
            AddNewTask(task);
        }

        private static void AddTaskWithDate(string[] parts)
        {
            var date = new DateTime.Parse(parts[1]);
            var task = new WeeklyTask(parts[0], date);
            AddNewTask(task);
        }

        private static void AddTaskWithDateTime(string[] parts)
        {
            var date = new DateTime.Parse(parts[1]);
            var time = new DateTime.Parse(parts[2]);
            var task = new WeeklyTask(parts[0], date, time);
            AddNewTask(task);
        }

        private static void AddTaskWithDateAndPriority(string[] parts)
        {
            var date = new DateTime.Parse(parts[1]);
            var time = new DateTime.Parse(parts[2]);

            if (Enum.TryParse<Priority>(parts[3], out var priority))
            {
                var task = new WeeklyTask(parts[0], date, time, priority);
                AddNewTask(task);
            }
        }

        private static void AddNewTask(WeeklyTask task)
        {
            tasks[s_counter] = task;
            s_counter++;
        }
    }
}
