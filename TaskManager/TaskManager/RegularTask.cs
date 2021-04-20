using System;
using TaskManagerNamespace;

namespace TaskManagerProject
{
    internal class RegularTask : WeeklyTask
    {
        internal DateTime _date;
        internal DateTime _time;

        public RegularTask()
        {
        }

        public RegularTask(string name, DateTime date)
        {
            base._name = name;
            _date = date;
        }

        public RegularTask(string name, DateTime date, DateTime time)
        {
            base._name = name;
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
}
}
