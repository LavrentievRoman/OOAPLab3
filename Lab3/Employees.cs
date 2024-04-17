using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public interface IVisitableElement
    {
        void Accept(IVisitor visitor);
    }

    public class Employee
    {
        public string fio { get; set; }
        public string phoneNum { get; set; }
        public string email { get; set; }

        public Employee(string fio, string phoneNum, string email)
        {
            this.fio = fio;
            this.phoneNum = phoneNum;
            this.email = email;
        }
    }

    public class OfficeEmployee : Employee, IVisitableElement
    { 
        public double salary { get; set; }
        public double bonus { get; set; }

        public OfficeEmployee(string fio, string phoneNum, string email, double salary, double bonus) : base (fio, phoneNum, email)
        {
            this.salary = salary;
            this.bonus = bonus;
        }

        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }

    public class Intern : Employee, IVisitableElement
    {
        public double bonus { get; set; }

        public Intern(string fio, string phoneNum, string email, double bonus) : base(fio, phoneNum, email)
        {
            this.bonus = bonus;
        }

        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }

}
