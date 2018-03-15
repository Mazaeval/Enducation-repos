using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progressions
{
    public interface ISeries
    {
        double GetCurrent();
        bool MoveNext();
        void Reset();
    }
}
