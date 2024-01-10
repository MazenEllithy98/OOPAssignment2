using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment2.Interfaces
{
    interface ISeries
    {
        public int Current { get; set; }

        public void GetNext();

        public void Reset()             // This is the only case we need to do a default implemented method as we will use the same method in all implementations of the interface
        {
            Current = 0;
        }
    }

    class SeriesByTwo : ISeries
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current += 2;
        }


    }
    class SeriesByThree : ISeries
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current += 3;
        }
    

    }
    class SeriesByFour : ISeries
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current += 4;
        }


    }

}
