using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class FTUBusiness : Business.IFTUBusiness
    {

        private int _totalGrace;
        public FTUBusiness(int passingMark, int gracePerSubject, int totalGrace)
        {
            PassingMark = passingMark;
            GracePerSubject = gracePerSubject;
            _totalGrace = totalGrace;

        }

        public int PassingMark { get; set; }
        public int GracePerSubject { get; set; }

        public List<SubjectScore> CalculateGraceMarks(List<SubjectScore> scores)
        {
            var totalGraceMarks = 0;
            foreach (var score in scores)
            {
                var graceRequired = (PassingMark - score.Score);
                if (score.Score < PassingMark && graceRequired <= GracePerSubject
                    && (graceRequired + totalGraceMarks) <= _totalGrace
                    )
                {
                    totalGraceMarks = totalGraceMarks + (PassingMark - score.Score);
                    score.Score = PassingMark;
                }
            }

            return scores;
        }

    }
}
