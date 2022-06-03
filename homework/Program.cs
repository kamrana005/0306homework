using System;
using homework030622;



namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            



            Employee emp1 = new Employee();
            emp1.EmployeeLimit = 4;
            emp1.AddEmployee(new Employee() { Name="Ali"} { Surname = "Alibayli"}
            { Salary=400})

            foreach(var item in emp1.Employees)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
