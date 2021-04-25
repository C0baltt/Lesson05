using System;
using TaskManagerNamespace;

namespace TaskManagerProject
{
    internal class PriorityTask : RegularTask
    {
        private readonly Priority _priority;

        public Priority GetPriority() => _priority;
        
        public PriorityTask(string name, DateTime date, DateTime time, Priority priority) : base(name, date, time)
        {
            _priority = priority;
        }
    }
}
