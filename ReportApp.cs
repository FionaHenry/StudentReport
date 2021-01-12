using System;
using System.Collections.Generic;

namespace StudentReport
{
    class ReportApp
    {
        public ReportApp()
        {
            List<Student> students = new List<Student>();

            students.Add(new Student("1", "2", "3", "4", "5"));
            students.Add(new Student("6", "7", "8", "9", "0"));

            foreach (Student student in students)
            {
                student.DisplayStudentDetails();
            }
        }

    }
}