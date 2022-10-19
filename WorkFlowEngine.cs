using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    public class WorkFlowEngine
    {
        public void Run(IWorkFlow workflow)
        {
            foreach (IPrintable print in workflow.GetAll())
            {
                print.printCommand();
            }
        }
    }
}
