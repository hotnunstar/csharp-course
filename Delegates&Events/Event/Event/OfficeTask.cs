using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class OfficeTask
    {
        public string TaskName { get; }

        public OfficeTask(string taskName)
        {
            TaskName = taskName;
        }
    }
}
