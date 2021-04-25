using System;
using TaskManagerNamespace;
using TaskManagerProject;

namespace TaskManagerProject
{
    internal class RegularTask : WeeklyTask
    {
        internal DateTime _date;
        internal DateTime _time;

        public RegularTask()
        {
        }

        public RegularTask(string name)
        {
            _name = name;
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

            return base.ConvertToString(index);
        }
    }
}
}
