using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SOLID_Implement_2._2_5_DIP
{
    #region Bad Code

    public interface IManagement
    {
        void AssignTask();
    }
    public class Manager : IManagement
    {
        public void AssignTask() { }
    }

    public class Worker
    {
        private IManagement _manager;

        public Worker(IManagement manager)
        {
            _manager = manager;
        }

        public void DoTask()
        {
            _manager.AssignTask();
        }
    }
    #endregion
}
