using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerNamespace
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

        public DateTime GetDate() => _date;
        

        public string ConvertToString(int index)
        {
            var output = $"Task №{index + 1}: {_name} ";
            if (_date != default)
            {
                output += $"{_date.ToShortDateString()} ";
            }

            if (_time != default)
            {
                output += $"{_time.ToShortDateString()} ";
            }

            if (_priority != Priority.Empty)
            {
                output += _priority.ToString();
            }

            return output;
        }
    }
}

