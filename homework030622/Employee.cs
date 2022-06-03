using System;
using System.Collections.Generic;
using System.Text;

namespace homework030622
{
    public class Employee
    {
        private string _name;
        private string _surname;
        private double _salary;

    }
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (Char.IsUpper(value[0]) && Char.IsLetter(value))
                _name = value;
        }
    }
    public string Surname
    {
        get
        {
            return _surname;
        }
        set
        {
            if (Char.IsUpper(value[0]) &&  Char.IsLetter(value))
                _surname = value;
        }


    }
    public string Salary
    {
        get
        {
            return _salary;
        }
        set
        {
            if (Salary(value) > 250)
                _salary = value;
        }
    }

     static bool HasLetter(string value)
    {
        for (int i = 0; i < value.Length; i++)
        {
            if (Char.IsDigit(value[i]))
                return true;
        }
        return false;


    
    




     }
}