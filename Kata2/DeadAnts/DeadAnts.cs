using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadAnts
{
    public class DeadAnts
    {
        public int DeadAntCount(string ants)
        {
            if (String.IsNullOrEmpty(ants))
            {
                return 0;
            }
            ants = ants.Replace("ant", "");
            int countHead = ants.Count(f => f == 'a');
            int countBody = ants.Count(f => f == 'n');
            int countTail = ants.Count(f => f == 't');
            int maxCount = Math.Max(countHead, Math.Max(countBody, countTail));
            return maxCount;
        }
    }
}
