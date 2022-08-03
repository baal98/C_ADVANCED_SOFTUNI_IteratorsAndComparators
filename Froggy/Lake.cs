using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        public List<int> Stones { get; set; }
        public int Index { get; set; }

        public Lake(List<int> stones)
        {
            this.Stones = stones;
            this.Index = 0;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < Stones.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return Stones[i];
                }
            }
            for (int i = Stones.Count - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return Stones[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        => this.GetEnumerator();
    }
}
