using System;
using System.Collections.Generic;

namespace c_classes
{
    public class Employee {
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string Title {get;set;}
        public DateTime StartDate {get;set;}
    }
    public class Company {
        // Create a constructor method that accepts two arguments:
        //     1. The name of the company
        //     2. The date it was created
        // The constructor will set the value of the public properties
        public Company(string Name, DateTime Date) {
            CompanyName = Name;
            DateFounded = Date;
            EmployeeList = new List<Employee>();
        }

        public DateTime DateFounded {get;}
        public string CompanyName {get;}
        public List<Employee> EmployeeList {get;set;}
        public void ListEmployees() {
           foreach(Employee employee in EmployeeList){
               Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {CompanyName} as {employee.Title} since {employee.StartDate}");
           }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        // Create an instance of a company. Name it whatever you like.
        Company NSS = new Company("Nashville Software School", DateTime.Now);

        // Create three employees
        Employee Jane = new Employee();
        Jane.FirstName = "Jane";
        Jane.LastName = "Thomas";
        Jane.Title = "CEO";
        Jane.StartDate = new DateTime(2018, 3, 8);

        Employee Jim = new Employee();
        Jim.FirstName = "Jim";
        Jim.LastName = "George";
        Jim.Title = "Temp";
        Jim.StartDate = new DateTime(2019, 3, 6);

        Employee Georgia = new Employee();
        Georgia.FirstName = "Georgia";
        Georgia.LastName = "Smith";
        Georgia.Title = "Recruiter";
        Georgia.StartDate = new DateTime(2017, 3, 16);

        // Assign the employees to the company
        NSS.EmployeeList.Add(Jane);
        NSS.EmployeeList.Add(Jim);
        NSS.EmployeeList.Add(Georgia);

        /*
            Iterate the company's employee list and generate the
            simple report shown above
        */
        NSS.ListEmployees();

        }
    }
}
