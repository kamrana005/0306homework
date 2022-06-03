using System;
using System.Collections.Generic;
using System.Text;

namespace homework030622
{
    public class Departament:Employee
    {
        public string Name;
        public int EmployeeLimit;
        public double SalaryLimit;
        public string Employees;

        

        




        private Employee[] Employees = new Employee[0];
        
        



        public void AddEmployee( Employee emp)
        {
            if(Employees.Length<EmployeeLimit&&_salary>SalaryLimit)
            Array.Resize(ref Employees, Employees.Length + 1);
            Employees[Employees.Length - 1] = emp;

        }
    }
}
