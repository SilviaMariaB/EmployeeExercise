using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExercise
{
    public class Employee
    {
        private const double noOfMonths = 12D;
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void GetARaise(double percentage)
        {

            //current salary is 50 -> we want to increase by 50% => new salary will be 75
            //50% of 50 = 25
            //50 + 25 = 75

            //50% / 100 = (0.5) * 50 = 25
            //percentage / 100 = X * salary = raise

            Salary += (percentage / 100D) * Salary;
        }
        public double getMonthlySalary()
        {
            return Salary / noOfMonths;
        }
        public override string ToString()
        {
            return $"{Name} makes {Salary} a year, which is {getMonthlySalary()} a month";
        }

    }
}
