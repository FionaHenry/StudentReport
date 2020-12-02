using System;
using System.Collections.Generic;

namespace StudentReport
{
    class Module
    {
        //MAKE IT CHECK THAT THE ASSIGNMENT WEIGHTS ADD UP TO 1
        List<Grade> studentGrades = new List<Grade>();
        public string moduleName;
        //public double moduleGrade;

        public Module(string name)
        {
            this.moduleName = name;
        }

        public void CalculateModuleGrade()
        {

        }
    }
}