using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class Comment
    {
        public string ID { get; set; }

        public string CommentText { get; set; }


        public readonly string _authorID;    //                  РАЗОБРАТЬСЯ С КОЛИЧЕСТВОМ ПОЛЕЙ    возможно нужно только public readonly

        public readonly string _taskID;

        private readonly DateTime _creatingDate;

        public DateTime UpdatingDate { get; set; }
        
        public Comment(string text, string authorID, string taskID)
        {
            ID = Guid.NewGuid().ToString();
            CommentText = text;
            _authorID = authorID;
            _taskID = taskID;
            _creatingDate = DateTime.Now;
            UpdatingDate = DateTime.Now;
        }
    }
}
