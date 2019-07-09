using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act9_2
{
    class PrioritySorter : IComparer<Request>
    {
        public int Compare(Request P1, Request P2)
        {
            return P1.Priority.CompareTo(P2.Priority);
        }
    }
}
