using Classes_Testing.Model;
using System;
using System.Collections.Generic;

namespace Classes_Testing
{
    public class Program
    {
        static void Main(string[] args)
        {            
            List<Employee> empList = new List<Employee>();

            Console.WriteLine("Hello World!");

            Employee emp1 = new Employee("Jon", "IT");
            Employee emp2 = new Employee("Hans", "DevOp");
            Employee emp3 = new Employee("Eva", "DB admin");
            Employee emp4 = new Employee("Ave", "DB manager", true);
            empList.Add(emp1);
            empList.Add(emp2);
            empList.Add(emp3);
            empList.Add(emp4);

            foreach (Employee emp in empList)
            {
                Console.WriteLine(emp.Information());
                
            }

        }

        public static double Divide(double num1, double num2)
        {
            double sum = 0;

            sum = num1 / num2;
            return sum;
        }
    }
}
