using Classes_Testing.Model;
using System;
using System.Collections.Generic;

namespace Classes_Testing
{
    public class Program
    {
        static void Main(string[] args)
        {
            double[] newDoubleArr = { 10.2, 10.4 };
            Add(newDoubleArr);

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
        // Double does't throws Divide by zero exception.
        public static double Divide(double num1, double num2)
        {
            double sum = 0;
            if (num2 == 0)
            {
                throw new DivideByZeroException("Can't divide by 0.");
            }
            sum = num1 / num2;
            return sum;
        }

        // Int throws Divide by zero exception.
        public static double DivideInt(int num1, int num2)
        {
            double sum = 0;

            sum = num1 / num2;
            return sum;
        }

        public static double Add(double[] numbs)
        {
            double sum = 0;
            for(int i = 0; i < numbs.Length; i++)
            {
                sum += numbs[i];
            }
            
            return sum;
        }
    }
}
