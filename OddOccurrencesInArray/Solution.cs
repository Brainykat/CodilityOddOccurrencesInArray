using System;
using System.Linq;

namespace OddOccurrencesInArray
{
    public class Solution
    {
        public int solution(int[] A)
        {
            if (A.Count() == 0) return -1;
            var a = from g in A.GroupBy(x => x)
                    where g.Count() == 1
                    select g.FirstOrDefault();
            
                return a.FirstOrDefault();

        }
    }
}
