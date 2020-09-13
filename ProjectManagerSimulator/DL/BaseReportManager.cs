using DL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class BaseReportManager : IReporter
    {
        private List<Task> _tasks; 

        public BaseReportManager(Board board)
        {
            _tasks = board.Tasks;
        }
        public List<Task> GetAll()
        {
            foreach(Task t in _tasks)
            {
                t.GetInfo();
            }
            return _tasks;
        }

        public List<Task> GetFromEstimateRange(double startEstimation = 0, double endEstimation = double.MaxValue)
        {
            return _tasks.Where(task => task.Estimation >= startEstimation && task.Estimation <= endEstimation).ToList();
        }
    }
}
