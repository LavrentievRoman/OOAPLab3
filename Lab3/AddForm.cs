using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class AddForm : Form
    {
        private MainForm mainform;
        public AddForm(MainForm form)
        {
            InitializeComponent();
            this.mainform = form;
        }

        private void internCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (internCheckBox.Checked)
            {
                salaryLabel.Enabled = false;
                salaryTextBox.Enabled = false;
            }
            else
            {
                salaryLabel.Enabled = true;
                salaryTextBox.Enabled = true;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string fio = fioTextBox.Text;
            string phoneNum = phoneNumTextBox.Text;
            string email = emailTextBox.Text;

            double salary = Convert.ToDouble(salaryTextBox.Text);
            double bonus = Convert.ToDouble(bonusTextBox.Text);

            if (!internCheckBox.Checked)
            {
                OfficeEmployee employee = new OfficeEmployee(fio, phoneNum, email, salary, bonus);

                var verificationVisitor = new VerificationVisitor();

                employee.Accept(verificationVisitor);

                if(verificationVisitor.correct)
                {
                    mainform.employees.Add(employee);
                    mainform.employeeList.Rows.Add(fio, phoneNum, email, salary, bonus, internCheckBox.Checked);

                    this.Close();
                }
            }
            else
            {
                Intern employee = new Intern(fio, phoneNum, email, bonus);
                salary = 0;

                var verificationVisitor = new VerificationVisitor();

                employee.Accept(verificationVisitor);

                if (verificationVisitor.correct)
                {
                    mainform.employees.Add(employee);
                    mainform.employeeList.Rows.Add(fio, phoneNum, email, salary, bonus, internCheckBox.Checked);

                    this.Close();
                }
            }

            var compenstionVisitor = new CompensationVisitor();
            mainform.employees.ForEach(em => em.Accept(compenstionVisitor));

            mainform.compensationLabel.Text = Convert.ToString(compenstionVisitor.TotationCompensation);
        }
    }
}
