using EmployeeApp.Domain.Enums;

namespace EmployeeApp.Domain.Models
{
    public class CEO : Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double SharesPrice { get; set; }

        public CEO(string firstName, string lastName, Role role, double salary, Employee[] employees, int shares, double sharesPrice) : base(firstName,lastName,role,salary)
        {
            Employees = employees;
            Shares = shares;
            SharesPrice = sharesPrice;
        }

        public void AddSharesPrice(double  sharesPrice)
        {
              SharesPrice += sharesPrice;
        }

        public void PrintEmployees(Employee[] arrayOfEmployees)
        {
            Console.WriteLine("Employees in the company:");
            foreach (Employee employee in arrayOfEmployees)
            { 
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }

        public override double GetSalary()
        {
            return Salary + Shares * SharesPrice;
        }


    }
}
