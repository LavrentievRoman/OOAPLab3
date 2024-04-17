namespace Lab3
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.employeeList = new System.Windows.Forms.DataGridView();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Intern = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.compensationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeList
            // 
            this.employeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIO,
            this.PhoneNum,
            this.Email,
            this.Salary,
            this.Bonus,
            this.Intern});
            this.employeeList.Location = new System.Drawing.Point(12, 51);
            this.employeeList.Name = "employeeList";
            this.employeeList.Size = new System.Drawing.Size(771, 387);
            this.employeeList.TabIndex = 0;
            // 
            // FIO
            // 
            this.FIO.HeaderText = "ФИО";
            this.FIO.Name = "FIO";
            // 
            // PhoneNum
            // 
            this.PhoneNum.HeaderText = "Телефон";
            this.PhoneNum.Name = "PhoneNum";
            // 
            // Email
            // 
            this.Email.HeaderText = "Почта";
            this.Email.Name = "Email";
            // 
            // Salary
            // 
            this.Salary.HeaderText = "Оклад";
            this.Salary.Name = "Salary";
            // 
            // Bonus
            // 
            this.Bonus.HeaderText = "Бонус";
            this.Bonus.Name = "Bonus";
            // 
            // Intern
            // 
            this.Intern.HeaderText = "Стажёр";
            this.Intern.Name = "Intern";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список сотрудников";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(811, 396);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(125, 42);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Внести сотрудника";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(813, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Общий оклад";
            // 
            // compensationLabel
            // 
            this.compensationLabel.AutoSize = true;
            this.compensationLabel.Location = new System.Drawing.Point(814, 90);
            this.compensationLabel.Name = "compensationLabel";
            this.compensationLabel.Size = new System.Drawing.Size(13, 13);
            this.compensationLabel.TabIndex = 4;
            this.compensationLabel.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 450);
            this.Controls.Add(this.compensationLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeList);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.employeeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView employeeList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bonus;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Intern;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label compensationLabel;
    }
}

