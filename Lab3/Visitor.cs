using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab3
{
    public interface IVisitor
    {
        void Visit(OfficeEmployee e);
        void Visit(Intern e);
    }

    public class CompensationVisitor : IVisitor
    {
        public double TotationCompensation { get; private set; } = 0;

        public void Visit(OfficeEmployee e)
        {
            TotationCompensation += e.salary + e.bonus;
        }

        public void Visit(Intern e)
        {
            TotationCompensation += e.bonus;
        }
    }

    public class VerificationVisitor : IVisitor
    {
        private string email = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                               @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
        private string phoneNum = @"((\+[0-9])|[0-9])-[0-9]{3}-[0-9]{3}-[0-9]{4}$";

        private string fio = @"\D+\s\D\.\s\D\.";

        public bool correct = true;
        public void Visit(OfficeEmployee e)
        {
            if (!Regex.IsMatch(e.email, email, RegexOptions.IgnoreCase))
            {
                correct = false;
                ErrorForm errorForm = new ErrorForm();
                errorForm.errorLabel.Text = "Поле Email должно быть заполнено в виде ex.mail@mail.ru";

                errorForm.Show();
            }

            if (!Regex.IsMatch(e.phoneNum, phoneNum, RegexOptions.IgnoreCase))
            {
                correct = false;
                ErrorForm errorForm = new ErrorForm();
                errorForm.errorLabel.Text = "Поле номер телефона должно быть заполнено в виде +7-111-222-3333\r\nИли 8-111-222-3333\r\n";

                errorForm.Show();
            }

            if (!Regex.IsMatch(e.fio, fio, RegexOptions.IgnoreCase))
            {
                correct = false;
                ErrorForm errorForm = new ErrorForm();
                errorForm.errorLabel.Text = "Поле ФИО должно быть заполненно в виде Иванов И. И.";

                errorForm.Show();
            }

            if (e.salary <= 0)
            {
                correct = false;
                ErrorForm errorForm = new ErrorForm();
                errorForm.errorLabel.Text = "Зарплата сотрудника не может быть меньше или равна 0";

                errorForm.Show();
            }
        }

        public void Visit(Intern e)
        {
            if (!Regex.IsMatch(e.email, email, RegexOptions.IgnoreCase))
            {
                correct = false;
                ErrorForm errorForm = new ErrorForm();
                errorForm.errorLabel.Text = "Поле Email должно быть заполнено в виде ex.mail@mail.ru";

                errorForm.Show();
            }

            if (!Regex.IsMatch(e.phoneNum, phoneNum, RegexOptions.IgnoreCase))
            {
                correct = false;
                ErrorForm errorForm = new ErrorForm();
                errorForm.errorLabel.Text = "Поле номер телефона должно быть заполнено в виде +7-111-222-3333\r\nИли 8-111-222-3333\r\n";

                errorForm.Show();
            }

            if (!Regex.IsMatch(e.fio, fio, RegexOptions.IgnoreCase))
            {
                correct = false;
                ErrorForm errorForm = new ErrorForm();
                errorForm.errorLabel.Text = "Поле ФИО должно быть заполненно в виде Иванов И. И.";

                errorForm.Show();
            }
        }
    }
}
