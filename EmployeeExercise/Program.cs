using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeExercise
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(1, "Dode", 12000);

            Console.WriteLine(employee);

            employee.GetARaise(50);

            Console.WriteLine(employee);

            Console.ReadLine();
        }
    }
}
