using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Testing.Model
{
    public class Employee
    {
        static int idCounter = 0;
        public bool Manager { get; set; }
        private readonly int id;
        public int ID { get { return id; } }
        public string department;
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if(value is null || value.Equals(""))
                {
                    throw new ArgumentException("Name cannot be empty or null");
                }
                name = value;
            }
        }

        public Employee()
        {
            this.id = ++idCounter;
        }

        public Employee(string name, string dep) : this()
        {
            this.Name = name;
            this.department = dep;
        }

        public Employee(string name, string dep, bool IsManager) : this(name, dep)
        {

            this.Manager = IsManager;
        }

        public string Information()
        {
            return $"Information Employee\n" +
                $"id: {ID}\n" +
                $"name: {Name}\n" +
                $"Department: {department}";
        }

        public static void ResetCounter()
        {
            idCounter = 0;
        }
    }
}
