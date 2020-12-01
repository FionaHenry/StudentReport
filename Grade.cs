using System;

namespace StudentReport
{
    class Grade
    {
        public int assignmentNumber;
        public int markRecieved;
        public double assignmentWeight;

        public Grade(int assignment, int mark, double weight)
        {
            this.assignmentNumber = assignment;
            this.markRecieved = mark;
            this.assignmentWeight = weight;
        }

    }
}