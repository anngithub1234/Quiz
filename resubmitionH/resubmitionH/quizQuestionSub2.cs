using System;
using System.Collections.Generic;
using System.Text;

namespace resubmitionH
{
    class quizQuestionSub2
    {
        public string Questions { get; set; }

        public string Hint { get; set; }

        public string[] Answer { get; set; }
        public int CoAnsw { get; set; }
        public quizQuestionSub2(string questions, string hint, string[] answer, int coAnsw)
        {
            Questions = questions;
            Answer = answer;
            CoAnsw = coAnsw;
            Hint = hint;
        }
    }
}
