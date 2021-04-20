using System;
using TaskManagerNamespace;

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
