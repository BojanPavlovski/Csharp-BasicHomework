using EmployeeApp.Domain.Enums;

namespace EmployeeApp.Domain.Models
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Role Responsible {  get; set; }

        public Contractor(string firstName, string lastName, Role role, double salary, double workHours, int payPerHour, Role responsible) : base(firstName,lastName,role,salary)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsible;
            
        }

        public override double GetSalary()
        {
           return  Salary = WorkHours * PayPerHour;
        }

        public Role CurrentPosition()
        {
            return Role.Manager;
        }


    }
}
