using EmployeeApp.Domain.Enums;

namespace EmployeeApp.Domain.Models
{
    public class SalesPerson : Employee
    {
        private double _successSalesRevenue { get; set; }

        public SalesPerson(string firstName, string lastName, double successSaleRevenue) : base(firstName, lastName, Role.Sales, 500)
        {
            _successSalesRevenue = successSaleRevenue;
        }

        public void AddSuccessRevenue(double amount)
        {
            _successSalesRevenue += amount;
        }

        public override double GetSalary()
        {
            if (_successSalesRevenue <= 2000)
            {
                return Salary + 500;
            }
            else if (_successSalesRevenue > 2000 && _successSalesRevenue <= 5000)
            {
                return Salary + 1000;
            }
            else
            {
                return Salary + 1500;
            }
        }
    }
}
