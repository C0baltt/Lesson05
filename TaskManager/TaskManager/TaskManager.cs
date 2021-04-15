using System;

namespace TaskManager
{
    class TaskManager
    {
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
                    HandleCommand();

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

        private static void HandleAddNewTask()
        {
            throw new NotImplementedException();
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
    }
}
