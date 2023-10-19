using System;
using System.Collections.Generic;
using System.Text;

namespace resubmitionH
{
    class quizQusetionsSub1
    {
        public string Questions { get; set; }

        public string[] Answer { get; set; }
        public int CoAnsw { get; set; }
        public quizQusetionsSub1(string questions, string[] answer, int coAnsw)
        {
            Questions = questions;
            Answer = answer;
            CoAnsw = coAnsw;
        }
    }
}
