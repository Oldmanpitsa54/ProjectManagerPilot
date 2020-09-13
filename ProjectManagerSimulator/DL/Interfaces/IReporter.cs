using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Interfaces
{
    public interface IReporter 
    {
        List<Task> GetAll();
        List<Task> GetFromEstimateRange(double startEstimation = 0, double endEstimation = double.MaxValue);
    }
}
