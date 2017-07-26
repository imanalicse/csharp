﻿using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<Employee> empList = new List<Employee>();

        empList.Add(new Employee() { ID = 101, Name = "Marry", Salary = 5000, Experience = 5 });
        empList.Add(new Employee() { ID = 102, Name = "Mike", Salary = 4000, Experience = 4 });
        empList.Add(new Employee() { ID = 103, Name = "John", Salary = 6000, Experience = 6 });
        empList.Add(new Employee() { ID = 104, Name = "Toddy", Salary = 3000, Experience = 3 });

        Employee.PromoteEmployee(empList);
    }
}

class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    public static void PromoteEmployee(List<Employee> empployeeList)
    {
        foreach(Employee employee in empployeeList)
        {
            if(employee.Experience >= 5)
            {
                Console.WriteLine(employee.Name + " promoted");
            }
        }
    }
}