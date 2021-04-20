using System;
using TaskManagerNamespace;

namespace TaskManagerProject
{
    internal class PriorityTask : RegularTask
    {
        private readonly Priority _priority;

        public Priority GetPriority() => _priority;
        public DateTime GetDate() => _date;

        public PriorityTask(string name, DateTime date, DateTime time, Priority priority)
        {
            base._name = name;
            _date = date;
            _time = time;
            _priority = priority;
        }
    }
}
