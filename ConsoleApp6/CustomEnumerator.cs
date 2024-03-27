using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class CustomEnumerator : IEnumerator<int>
    {
        public int Current { get; private set; } = -1;

        object IEnumerator.Current => 0;

        public void Dispose()
        {
            Current = 0;
        }

        public bool MoveNext()
        {
            
            if (Current <10 )
            {
                Current++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            Current = 0;
        }
    }
}
