using System;
using System.Collections.Generic;

namespace StudentReport
{
    class ReportApp
    {
        public ReportApp()
        {
            List<Student> students = new List<Student>();

            students.Add(new Student("123", "John", "Smith", "1/2/90", "Computing"));
            students.Add(new Student("234", "Ann", "Grey", "3/1/94", "Computing"));

            students[0].gradeProfile.moduleResults.Add(new Module("Networking"));
            students[0].gradeProfile.moduleResults[0].studentGrades.Add(new Grade(010, 62, 0.5));
            students[0].gradeProfile.moduleResults[0].studentGrades.Add(new Grade(011, 58, 0.5));

            students[0].gradeProfile.moduleResults.Add(new Module("OOP"));
            students[0].gradeProfile.moduleResults[1].studentGrades.Add(new Grade(010, 54, 0.3));
            students[0].gradeProfile.moduleResults[1].studentGrades.Add(new Grade(011, 61, 0.7));

            students[1].gradeProfile.moduleResults.Add(new Module("Networking"));
            students[1].gradeProfile.moduleResults[0].studentGrades.Add(new Grade(010, 81, 0.5));
            students[1].gradeProfile.moduleResults[0].studentGrades.Add(new Grade(011, 67, 0.5));

            students[1].gradeProfile.moduleResults.Add(new Module("OOP"));
            students[1].gradeProfile.moduleResults[1].studentGrades.Add(new Grade(010, 76, 0.3));
            students[1].gradeProfile.moduleResults[1].studentGrades.Add(new Grade(011, 64, 0.7));

            foreach (Student student in students)
            {
                student.DisplayStudentDetails();
            }
        }

    }
}