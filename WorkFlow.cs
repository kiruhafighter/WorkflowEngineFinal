using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    public class WorkFlow : IWorkFlow
    {
        private readonly IList<IPrintable> _iprints;
        public WorkFlow()
        {
            _iprints = new List<IPrintable>();
        }

        

        public void Add(IPrintable I)
        {
            _iprints.Add(I);
        }

        public void Remove(IPrintable I)
        {
            _iprints.Remove(I);
        }

        public IEnumerable<IPrintable> GetAll()
        {
            return _iprints;
        }
    }
}
