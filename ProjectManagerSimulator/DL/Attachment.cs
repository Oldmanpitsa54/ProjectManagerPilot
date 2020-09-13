using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
   public class Attachment
    {
        public string Name { get; set; }

        public string Link { get; set; }

        public readonly string _userID;        

        public readonly string _taskID;

        public string ID { get; set; }

        public readonly DateTime _creatingDate;

        public DateTime UpdatingDate { get; set; }

        public Attachment(string name, string link, string userID, string taskID)
        {
            Name = name;
            Link = link;
            _userID = userID;
            _taskID = taskID;
            _creatingDate = DateTime.Now;
            UpdatingDate = DateTime.Now;


        }
    }
}
