using EmployeeApp.Domain.Enums;
using EmployeeApp.Domain.Models;


//code from class

Employee employee = new Employee("John", "Johnsky", Role.Other, 600);
employee.PrintInfo();
double employeeSalary = employee.GetSalary();
Console.WriteLine(employeeSalary);

Manager manager = new Manager("Bob", "Bobsky", Role.Manager, 1000);
manager.PrintInfo(); //inherited from Employee
manager.AddBonus(100);
double managerSalary = manager.GetSalary();
Console.WriteLine(managerSalary);

SalesPerson salesPerson = new SalesPerson("Kate", "Katesky", 500);
salesPerson.PrintInfo();
salesPerson.AddSuccessRevenue(2000);
Console.WriteLine(salesPerson.GetSalary());

//Homework,task 2 & 3:

Console.WriteLine("Task 2");
Contractor contractor = new Contractor("Bojan", "Pavlovski", Role.Other, 550, 86, 14, Role.Other);
contractor.PrintInfo();
contractor.CurrentPosition();
double contractorSalary = contractor.GetSalary();
Console.WriteLine(contractorSalary);

Console.WriteLine("Task 3");
//Array of company employees
Employee[] Company =
{
    new Contractor("Petko", "Petkovski", Role.Other, 550, 86, 14, Role.Other),
    new Contractor("Stojan", "Stojanovski", Role.Other, 450, 90, 14, Role.Other),

    new Manager("Bob", "Bobsky", Role.Manager, 1000),
    new Manager("Blazo", "Blzevski", Role.Manager, 1500),

    new SalesPerson("Dragana", "Petkovska", 580)

};
//ceo instance
CEO ceo = new CEO("John", "Johnson", Role.CEO, 1500, Company, 95, 1200);
ceo.PrintInfo();
ceo.PrintEmployees(Company);
double ceoSalary = ceo.GetSalary();
Console.WriteLine(ceoSalary);

