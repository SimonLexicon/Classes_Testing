using System;
using System.Collections.Generic;
using System.Text;
using Classes_Testing.Model;
using Xunit;

namespace Classes_Testing.TestProject1
{
   
    public class TestingEmplyeeClass
    {
        public TestingEmplyeeClass()
        {
            Employee.ResetCounter();
        }

        [Fact]
        public void ConstructorTest()
        {
            string name = "Testson";
            string dep = "DB manager";
            bool isManager = true;
            Employee emp4 = null;
            emp4 = new Employee(name, dep, isManager);

            Assert.NotNull(emp4);
            Assert.Equal(emp4.Name, name);
            Assert.Equal(emp4.department, dep);
            Assert.Equal(emp4.Manager, isManager);
            Assert.Equal( 1, emp4.ID);


        }

        [Fact]
        public void IDCounterTest()
        {
            string name = "Testson";
            string dep = "DB manager";
            bool isManager = true;
            Employee emp4 = null;
            emp4 = new Employee(name, dep, isManager);
            emp4 = new Employee(name, dep, isManager);
            emp4 = new Employee(name, dep, isManager);
            emp4 = new Employee(name, dep, isManager);



            Assert.Equal(emp4.Name, name);
            Assert.Equal(emp4.department, dep);
            Assert.Equal(emp4.Manager, isManager);
            Assert.Equal( 4, emp4.ID);
        }

        [Theory]
        [InlineData("", "Name cannot be empty")]
        [InlineData(null, "Name cannot be empty or null")]
        public void NamePropertyTest(string name, string expectedMessage)
        {

            var resultExcept = Assert.Throws<ArgumentException>(
                () => new Employee(name, "Science"));
            Employee newEmp = new Employee();

            Assert.Throws<ArgumentException>(() => newEmp.Name = name);

            Assert.Equal(expectedMessage, resultExcept.Message);
        }

    }
}
