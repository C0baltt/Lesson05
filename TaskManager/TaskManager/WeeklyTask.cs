using System;
using TaskManagerNamespace;
using TaskManagerProject;

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
            return $"Task №{index + 1}: {_name} ";
        }
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
