﻿using ClassStatistics;

namespace Wyzwanie21dn
{
    internal class EmployeeInMemory : EmployeeBase // : IEmployee
    {
        public EmployeeInMemory(string name, string surname, string age) 
            : base(name, surname, age)
        {
        }

        public override void AddGrade(float grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(string grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(int grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public override Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
