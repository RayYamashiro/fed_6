using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class GradeDatabase
    {
        private Dictionary<string, string> grades;

        public GradeDatabase()
        {
            grades = new Dictionary<string, string>();
        }

        public void AddGrade(string department, string grade)
        {
            grades[department] = grade;
        }

        public string GetGrade(string department)
        {
            return grades.ContainsKey(department) ? grades[department] : null;
        }

        public string GetGradeForInstructor(string instructor)
        {
            List <IObserver> ob =   DeanOffice.GetObservers();
            
            foreach (var grade in grades)
            {
                if (ob.Contains(new Instructor(instructor , grade.Key)))
                //if (grade.Key.Contains(instructor))
                {
                    return grade.Value;
                }
            }
            return null;
        }
    }
}
