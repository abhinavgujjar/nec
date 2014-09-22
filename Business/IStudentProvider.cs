using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public interface IStudentProvider
    {
        List<SubjectScore> GetScores(int studentId);

    }
}
