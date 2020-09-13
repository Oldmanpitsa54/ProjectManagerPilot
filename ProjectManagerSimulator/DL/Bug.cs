using DL.TaskTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
   public class Bug : BaseTask
    {
        public Bug(string title, double est, string descr, TaskType type, User creator, User owner, Status currStatus = Status.BackLog) : base(title, est, descr, type, creator, owner, currStatus )
        {

        }
        public override void GetInfo()
        {
            Console.WriteLine("Bug");
        }
    }
}
