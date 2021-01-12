using System;
using System.Collections.Generic;

namespace StudentReport
{
    class GradeProfile
    {
        public List<Module> moduleResults = new List<Module>();
        public double moduleGrade;
        
        public void CalculateAverageGrade()
        {
            foreach(Module result in moduleResults)
            {
                Console.WriteLine(result.moduleName);
                foreach(Grade grade in result.studentGrades)
                {
                    moduleGrade+=(grade.markRecieved * grade.assignmentWeight);
                    grade.DisplayGrade();
                }
                Console.WriteLine($"Overall module grade: {moduleGrade}");
            }
        }

    }
}