using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class CustomTaskAssignmentManager : TaskAssignmentManager
    {
        protected override void OnTaskAssigned(OfficeTask task)
        {
            Console.WriteLine("Custom logic before task assignment");
            base.OnTaskAssigned(task);
            Console.WriteLine("Custome logic after task assignment");
        }

        private void CustomTaskHandler(object sender, OfficeTask task)
        {
            Console.WriteLine($"New task assigned: {task.TaskName}");
        }

        public CustomTaskAssignmentManager()
        {
            TaskAssigned += CustomTaskHandler;
        }
    }
}
