using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerNamespace
{
    internal abstract class WeeklyTask
    {
        internal string _name;
        
        public WeeklyTask()
        {
        }

        public WeeklyTask(string name)
        {
            _name = name;
        }
        
        public virtual string ConvertToString(int index)
        {
            var output = $"Task №{index + 1}: {_name} ";
            
            return output;
        }
    }

    internal class RegularTask : WeeklyTask
    {
        internal DateTime _date;
        internal DateTime _time;

        public RegularTask()
        {
        }

        public RegularTask(string name, DateTime date)
        {
            _name = name;
            _date = date;
        }

        public RegularTask(string name, DateTime date, DateTime time)
        {
            _name = name;
            _date = date;
            _time = time;
        }

        public DateTime GetDate() => _date;

        public override string ConvertToString(int index)
        {
            var output = base.ConvertToString(index);

            return output;
        }
    }

    internal class PriorityTask : RegularTask
    {
        private readonly Priority _priority;

        public Priority GetPriority() => _priority;
        public DateTime GetDate() => _date;

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
}

