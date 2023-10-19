using System;
using System.Collections.Generic;
using System.Text;

namespace resubmitionH
{
    class Examinator
    {
        public string Exname { get; set; }
        private static int ExId = 1;
        public int exId { get; }

        public Examinator(string exname)
        {

            exname = Exname;
            exId = ExId++;

        }
    }
}
