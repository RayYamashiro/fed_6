using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Instructor : IObserver
    {
        private string name;
        private string instructorGrade;
        public Instructor(string name , string instructorGrade)
        {
            this.name = name;
            this.instructorGrade = instructorGrade;
        }

        public void Update(ISubject subject)
        {
            GradeDatabase gradeDatabase = ((DeanOffice)subject).GetGradeDatabase();
            string grade = gradeDatabase.GetGradeForInstructor(name);

            if (grade == null)
            {
                Console.WriteLine("Instructor {0}: No current grade available.", name);
            }
            else
            {
                Console.WriteLine("Instructor {0}: Current grade is {1}.", name, grade);
            }
        }
    }
}
