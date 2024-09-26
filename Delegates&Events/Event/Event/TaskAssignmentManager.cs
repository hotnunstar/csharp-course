using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class TaskAssignmentManager
    {
        public delegate void TaskAssignedEventHandler(object sender, OfficeTask task);
        public event TaskAssignedEventHandler TaskAssigned;

        protected virtual void OnTaskAssigned(OfficeTask task)
        {
            TaskAssigned?.Invoke(this, task);
        }

        public void AssignTask(string taskName)
        {
            OfficeTask newTask = new OfficeTask(taskName);
            OnTaskAssigned(newTask);
        }
    }
}
