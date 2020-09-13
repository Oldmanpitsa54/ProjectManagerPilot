using DL.TaskTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public abstract class BaseTask
    {
        public string Title { get; set; }

        public double Estimation { get; set; }

        public string Description { get; set; }

        public string ID { get; set; }

        public TaskType Type { get; set; }

        private readonly DateTime _creatingDate;

        public DateTime UpdatingDate { get; set; }

        private User _creator;

        public readonly User creator;

        public User Owner { get; set; }

        public Status CurrStatus { get; set; }

        public BaseTask()
        {

        }

        public BaseTask(string title,  double est, string descr, TaskType type, User creator, User owner, Status currStatus = Status.BackLog)
        {
            Title = title;
            ID = Guid.NewGuid().ToString();
            Description = descr;
            Estimation = est;
            _creator = creator;
            Owner = owner;
            Type = type;
            _creatingDate = DateTime.Now;
            UpdatingDate = DateTime.Now;
            CurrStatus = currStatus;
        }

        public abstract void GetInfo();

    }
}
      

