using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shit3
{
    struct Challenge
    {
        HostSentence hostSentence;
        List<Position> solution;

        public Challenge(HostSentence hostSentence, List<Position> solution)
        {
            this.hostSentence = hostSentence;
            this.solution = solution;
        }

        public HostSentence HostSentence
        {
            get
            {
                return this.hostSentence;
            }
        }

        public List<Position> Solution
        {
            get
            {
                return this.solution;
            }
        }
    }
}
