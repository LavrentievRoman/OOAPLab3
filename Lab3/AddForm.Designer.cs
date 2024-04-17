namespace Lab3
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneNumTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.internCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bonusTextBox = new System.Windows.Forms.TextBox();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // fioTextBox
            // 
            this.fioTextBox.Location = new System.Drawing.Point(119, 12);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(214, 20);
            this.fioTextBox.TabIndex = 1;
            this.fioTextBox.Text = "Иванов И. И.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер телефона";
            // 
            // phoneNumTextBox
            // 
            this.phoneNumTextBox.Location = new System.Drawing.Point(119, 45);
            this.phoneNumTextBox.Name = "phoneNumTextBox";
            this.phoneNumTextBox.Size = new System.Drawing.Size(214, 20);
            this.phoneNumTextBox.TabIndex = 3;
            this.phoneNumTextBox.Text = "8-111-222-3333";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "E-mail";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(119, 81);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(214, 20);
            this.emailTextBox.TabIndex = 5;
            this.emailTextBox.Text = "ex.mail@mail.ru";
            // 
            // internCheckBox
            // 
            this.internCheckBox.AutoSize = true;
            this.internCheckBox.Location = new System.Drawing.Point(14, 117);
            this.internCheckBox.Name = "internCheckBox";
            this.internCheckBox.Size = new System.Drawing.Size(64, 17);
            this.internCheckBox.TabIndex = 6;
            this.internCheckBox.Text = "Стажёр";
            this.internCheckBox.UseVisualStyleBackColor = true;
            this.internCheckBox.CheckedChanged += new System.EventHandler(this.internCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Бонус";
            // 
            // bonusTextBox
            // 
            this.bonusTextBox.Location = new System.Drawing.Point(119, 145);
            this.bonusTextBox.Name = "bonusTextBox";
            this.bonusTextBox.Size = new System.Drawing.Size(214, 20);
            this.bonusTextBox.TabIndex = 8;
            this.bonusTextBox.Text = "0";
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(16, 183);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(39, 13);
            this.salaryLabel.TabIndex = 9;
            this.salaryLabel.Text = "Оклад";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(119, 183);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(214, 20);
            this.salaryTextBox.TabIndex = 10;
            this.salaryTextBox.Text = "10000";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(237, 231);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(96, 33);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Внести";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 293);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.bonusTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.internCheckBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phoneNumTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fioTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fioTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phoneNumTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.CheckBox internCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bonusTextBox;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.Button addButton;
    }
}