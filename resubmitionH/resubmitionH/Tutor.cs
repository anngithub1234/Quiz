using System;
using System.Collections.Generic;
using System.Text;

namespace resubmitionH
{
    class Tutor
    {
        public string Tutname { get; set; }
        private static int Tutid = 1;
        public int tutId { get; }

        public Tutor(string tutname)
        {
            Tutname = tutname;
            tutId = Tutid++;

        }
    }
}
