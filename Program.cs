﻿using System;

namespace StudentReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("A", "B", "C", "12/34/5678", "ABC");

            //display student details method
            //display student report card method

            s1.DisplayStudentDetails();
            //s1.DisplayReportCard();
        }
    }
}