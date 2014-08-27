namespace SalaryMoney
{
    using System.Collections.Generic;
    
    public class Employee
    {
        private string name;
        private int salary;
        private List<Employee> subordinates;

        public Employee(string name)
        {
            this.Name = name;
            this.Salary = 1;
            this.Subordinates = new List<Employee>();
        }

        public List<Employee> Subordinates 
        {
            get
            {
                return this.subordinates;
            }

            private set
            {
                this.subordinates = value;
            }
        }

        public int Salary
        {
            get
            {
                return this.salary;
            }

            set
            {
                this.salary = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                this.name = value;
            }
        }
    }
}