
using System.Collections;

namespace ConsoleApp6
{
    internal class CustomEmumerable : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            return new CustomEnumerator();
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return new CustomEnumerator();
        }
    }
}