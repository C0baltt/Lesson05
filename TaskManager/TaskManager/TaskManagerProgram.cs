using System;
using static System.DateTime;

namespace TaskManagerNamespace
{
    public class TaskManagerProgram
    {
        private static WeeklyTaskService s_service = new WeeklyTaskService();

        static void Main(string[] args)
        {
            RunInLoop();
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
                else if(input == "exit")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Invalid command. Remember, you must only enter numbers from 1 to 5! Try again, or type \"exit\" to close the app");
                }
            }
        }

        private static void PrintMenu()
        {

            Console.WriteLine("\n" + @"Choose a command:
1. Add new task
2. List all tasks
3. Edit task
4. Filter by date
5. Filter by priority" + "\n");
        }

        private static void HandleCommand(int parsedInput)
        {
            switch (parsedInput)
            {
                case 1:
                    s_service.HandleAddNewTask();
                    break;
                case 2:
                    s_service.HandleList();
                    break;
                case 3:
                    s_service.HandleEdit();
                    break;
                case 4:
                    s_service.HandleFilterByDate();
                    break;
                case 5:
                    s_service.HandleFilterByPriority();
                    break;
            }
        }
    }
}
