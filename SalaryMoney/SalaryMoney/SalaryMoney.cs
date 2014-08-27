namespace SalaryMoney
{
    using System;
    using System.Collections.Generic;

    public class SalaryMoney
    {
        private static int allSalaries = 0;

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            Dictionary<string, Employee> employees = new Dictionary<string, Employee>();

            string bossName = Console.ReadLine();
            Employee theBigBoss = new Employee(bossName);
            employees.Add(bossName, theBigBoss);

            for (int i = 0; i < n - 1; i++)
            {
                string name = Console.ReadLine();
                Employee employee = new Employee(name);
                employees.Add(name, employee);
            }

            for (int i = 0; i < m; i++)
            {
                string line = Console.ReadLine();
                string[] names = line.Split(' ');
                string superior = names[0];

                for (int j = 1; j < names.Length; j++)
                {
                    employees[superior].Subordinates.Add(employees[names[j]]);
                }
            }

            Dfs(theBigBoss);
            Console.WriteLine(allSalaries);
        }

        public static void Dfs(Employee root)
        {
            if (root.Subordinates.Count == 0)
            {
                allSalaries += root.Salary;
                return;
            }

            int salary = 0;
            foreach (var employee in root.Subordinates)
            {
                Dfs(employee);
                salary += employee.Salary;
            }

            root.Salary = salary;
            allSalaries += root.Salary;
        }
    }
}