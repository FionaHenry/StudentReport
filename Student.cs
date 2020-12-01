using System;

namespace StudentReport
{
    class Student
    {
        GradeProfile gradeProfile = new GradeProfile();
        public string studentID;
        public string firstName;
        public string surname;
        public string dateOfBirth;
        public string course;

        public Student(string id, string firstName, string surname, string dob, string course)
        {
            this.studentID = id;
            this.firstName = firstName;
            this.surname = surname;
            this.dateOfBirth = dob;
            this.course = course;
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine(studentID);
            Console.WriteLine($"{firstName} {surname}");
            Console.WriteLine(dateOfBirth);
            Console.WriteLine(course);
        }

        public void DisplayReportCard()
        {
            /*foreach(Module module in studentGrades)
            {
                Console.WriteLine($"Module: {module.moduleName}");
                
            }*/
        }
        
    }
}