using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Employment
{
    public class Employee
    {
        private string _firstName;
        private string _lastName;
        private double _monthlySalary;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public double MonthlySalary
        {
            get { return _monthlySalary; }
            set
            {
                if (value > 0) _monthlySalary = value;
            }
        }


        public Employee(string Fir, string Las, double Mon)
        {
            if (string.IsNullOrEmpty(Fir) || string.IsNullOrEmpty(Las)) 
            {
                Fir = "Unknown";
                Las = "Unknown";
            }
            if (Mon < 0) Mon = 0;
            FirstName = Fir;
            LastName = Las;
            MonthlySalary = Mon;
        }
        public void RaiseSalary(int raisePercentage) 
        {
            if (raisePercentage <= 20 && raisePercentage > 0)
            {
                double multiplier = 1 + ((double)raisePercentage / 100);
                MonthlySalary *= multiplier;
            }
        }
        public double GetYearlySalary()
        {
            double total = this.MonthlySalary * 12;
            return total;
        }
    }

}
