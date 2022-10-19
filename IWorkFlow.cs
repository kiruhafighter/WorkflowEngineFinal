using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    
    public interface IWorkFlow
    {
        void Add(IPrintable I);
        void Remove(IPrintable I);

        IEnumerable<IPrintable> GetAll();
    }
}
