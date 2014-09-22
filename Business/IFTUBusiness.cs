using System;
namespace Business
{
    public interface IFTUBusiness
    {
        System.Collections.Generic.List<Model.SubjectScore> CalculateGraceMarks(System.Collections.Generic.List<Model.SubjectScore> scores);
        int GracePerSubject { get; set; }
        int PassingMark { get; set; }
    }
}
