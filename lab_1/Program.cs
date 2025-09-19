using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class Challenge
    {
        public string subj = "Любой";
        public string name = "Без названия";
        public string date = "00.00.00";
        public Challenge() { }
        public Challenge(string subj, string name, string date)
        {
            this.subj = subj;
            this.name = name;
            this.date = date;
        }
    }

    public class Exam:Challenge
    {
        private int pointsToPass = 0;
        private string acceptKey = "none";
        public Exam() { }
        public Exam(string subj, string name, string date, int pointsToPass, string acceptKey):
            base(subj, name, date)
        {
            this.pointsToPass = pointsToPass;
            this.acceptKey = acceptKey;
        }
        public bool Pass(int points)
        {
            if (pointsToPass <= points)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class EExam:Exam
    {
        private int pasportID = 1234;
        private string indx = "xxxx-xxxx";
        public EExam() { }
        public EExam(string subj, string name, string date, int pointsToPass, string acceptKey, int pasportID, string indx)
            : base(subj, name, date, pointsToPass, acceptKey)
        { this.pasportID = pasportID; this.indx = indx;}      
    }

    public class Test : Challenge
    {
        public int maxPoints = 0;
        public Test(string subj, string name, string date, int maxPoints)
            :base(subj, name, date)
        {
            this.maxPoints = maxPoints;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Exam ex = new Exam("русский","тест на знание","18.09.2025",40,"Tim1");
            Console.WriteLine(ex.Pass(23));

        }
    }
}
