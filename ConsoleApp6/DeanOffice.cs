using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class DeanOffice : ISubject
    {
        private static List<IObserver> observers;
        private GradeDatabase gradeDatabase;

        public DeanOffice()
        {
            observers = new List<IObserver>();
            gradeDatabase = new GradeDatabase();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(this);
            }
        }

        public void AddGrade(string department, string grade)
        {
            gradeDatabase.AddGrade(department, grade);
            NotifyObservers();
        }

        public GradeDatabase GetGradeDatabase()
        {
            return gradeDatabase;
        }
        public static List<IObserver> GetObservers()
        {
            return observers;
        }
    }
}
