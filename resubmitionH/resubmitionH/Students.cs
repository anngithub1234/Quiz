using System;
using System.Collections.Generic;
using System.Text;

namespace resubmitionH
{
    class Students
    {
        public string StdName { get; set; }
        private static int StId = 1;
        public int stid { get; }
       
        public Students(string stdname)
        {
            StdName = stdname;
            stid = StId++;

        }
    }
}
