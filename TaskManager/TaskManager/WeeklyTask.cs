using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal class WeeklyTask
    {
        private string _name;
        private DateTime _date;
        private DateTime _time;
        private readonly Priority _priority;

        public WeeklyTask(string name)
        {
            _name = name;
        }

        public WeeklyTask(string name, DateTime date)
        {
            _name = name;
            _date = date;
        }

        public WeeklyTask(string name, DateTime date, DateTime time)
        {
            _name = name;
            _date = date;
            _time = time;
        }

        public WeeklyTask(string name, DateTime date, DateTime time, Priority priority)
        {
            _name = name;
            _date = date;
            _time = time;
            _priority = priority;
        }

        public string ConvertToString(int index)
        {
            return $"Task №{index + 1}: {_name} - {_name} - {_time} - {_priority}";
        }
    }
}

