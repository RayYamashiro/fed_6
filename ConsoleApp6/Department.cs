using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Department : IObserver
    {
        private string name;

        public Department(string name)
        {
            this.name = name;
        }

        public void Update(ISubject subject)
        {
            GradeDatabase gradeDatabase = ((DeanOffice)subject).GetGradeDatabase();
            string grade = gradeDatabase.GetGrade(name);

            if (grade == null)
            {
                Console.WriteLine("Department {0}: No current grade available.", name);
            }
            else
            {
                Console.WriteLine("Department {0}: Current grade is {1}.", name, grade);
            }
        }
    }
}
