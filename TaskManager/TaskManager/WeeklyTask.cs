using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerNamespace
{
    internal class PriorityTask : WeeklyTask
    {
        private readonly Priority _priority;

        public Priority GetPriority() => _priority;

        public PriorityTask(string name, DateTime date, DateTime time, Priority priority)
        {
            _name = name;
            _date = date;
            _time = time;
            _priority = priority;
        }

        public override string ConvertToString(int index)
        {
            var output = base.ConvertToString(index);

            if (_priority != Priority.Empty)
            {
                output += _priority.ToString();
            }

            return output;
        }
    }

    internal class WeeklyTask
    {
        internal string _name;
        internal DateTime _date;
        internal DateTime _time;

        public WeeklyTask()
        {
        }

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

        public DateTime GetDate() => _date;
        
        public virtual string ConvertToString(int index)
        {
            var output = $"Task №{index + 1}: {_name} ";
            if (_date != default)
            {
                output += $"{_date.ToShortDateString()} ";
            }

            if (_time != default)
            {
                output += $"{_time.ToShortTimeString()} ";
            }

            return output;
        }
    }
}

