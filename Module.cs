using System;
using System.Collections.Generic;

namespace StudentReport
{
    class Module
    {
        static List<Grade> studentGrades = new List<Grade>();
        
        public string moduleName;

        public Module(string name)
        {
            this.moduleName = name;
        }
    }
}