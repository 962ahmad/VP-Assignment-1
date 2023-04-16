using System.Windows.Forms;

namespace Assignment4
{
    partial class HumanResources
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
            this.txtNationalNumber = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.btnCreateEmployee = new System.Windows.Forms.Button();
            this.lblNationalNumber = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblDateOFBirth = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.clbListOfSkills = new System.Windows.Forms.CheckedListBox();
            this.lblSkills = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNationalNumber
            // 
            this.txtNationalNumber.Location = new System.Drawing.Point(251, 40);
            this.txtNationalNumber.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNationalNumber.Name = "txtNationalNumber";
            this.txtNationalNumber.Size = new System.Drawing.Size(402, 31);
            this.txtNationalNumber.TabIndex = 0;
            this.txtNationalNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNationalNumber_KeyPress);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(251, 90);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(402, 31);
            this.txtFullName.TabIndex = 1;
            this.txtFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFullName_KeyPress);
            // 
            // dtpBirth
            // 
            this.dtpBirth.Location = new System.Drawing.Point(251, 142);
            this.dtpBirth.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dtpBirth.MaxDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(402, 31);
            this.dtpBirth.TabIndex = 2;
            this.dtpBirth.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Items.AddRange(new object[] {
            "Jordan ",
            "Egypt",
            "syria"});
            this.cbCountry.Location = new System.Drawing.Point(251, 194);
            this.cbCountry.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(402, 33);
            this.cbCountry.TabIndex = 3;
            this.cbCountry.SelectedValueChanged += new System.EventHandler(this.cbCountry_SelectedValueChanged);
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(251, 248);
            this.cbCity.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(402, 33);
            this.cbCity.TabIndex = 4;
            // 
            // btnCreateEmployee
            // 
            this.btnCreateEmployee.Location = new System.Drawing.Point(97, 573);
            this.btnCreateEmployee.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCreateEmployee.Name = "btnCreateEmployee";
            this.btnCreateEmployee.Size = new System.Drawing.Size(556, 115);
            this.btnCreateEmployee.TabIndex = 9;
            this.btnCreateEmployee.Text = "Create Employee";
            this.btnCreateEmployee.UseVisualStyleBackColor = true;
            this.btnCreateEmployee.Click += new System.EventHandler(this.btnCreateEmployee_Click);
            // 
            // lblNationalNumber
            // 
            this.lblNationalNumber.AutoSize = true;
            this.lblNationalNumber.Location = new System.Drawing.Point(91, 52);
            this.lblNationalNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNationalNumber.Name = "lblNationalNumber";
            this.lblNationalNumber.Size = new System.Drawing.Size(143, 25);
            this.lblNationalNumber.TabIndex = 10;
            this.lblNationalNumber.Text = "National Number";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(91, 103);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(90, 25);
            this.lblFullName.TabIndex = 11;
            this.lblFullName.Text = "Full Name";
            // 
            // lblDateOFBirth
            // 
            this.lblDateOFBirth.AutoSize = true;
            this.lblDateOFBirth.Location = new System.Drawing.Point(91, 156);
            this.lblDateOFBirth.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDateOFBirth.Name = "lblDateOFBirth";
            this.lblDateOFBirth.Size = new System.Drawing.Size(50, 25);
            this.lblDateOFBirth.TabIndex = 12;
            this.lblDateOFBirth.Text = "Birth";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(92, 209);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(74, 25);
            this.lblCountry.TabIndex = 13;
            this.lblCountry.Text = "Country";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(92, 263);
            this.lblCity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(42, 25);
            this.lblCity.TabIndex = 14;
            this.lblCity.Text = "City";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(91, 318);
            this.lblGender.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(72, 25);
            this.lblGender.TabIndex = 15;
            this.lblGender.Text = "Gender";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(251, 318);
            this.rbMale.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(68, 29);
            this.rbMale.TabIndex = 16;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(341, 318);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(89, 29);
            this.rbFemale.TabIndex = 17;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // clbListOfSkills
            // 
            this.clbListOfSkills.FormattingEnabled = true;
            this.clbListOfSkills.Items.AddRange(new object[] {
            "programming",
            "web design",
            "UI/UX"});
            this.clbListOfSkills.Location = new System.Drawing.Point(251, 378);
            this.clbListOfSkills.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.clbListOfSkills.Name = "clbListOfSkills";
            this.clbListOfSkills.Size = new System.Drawing.Size(402, 160);
            this.clbListOfSkills.TabIndex = 18;
            // 
            // lblSkills
            // 
            this.lblSkills.AutoSize = true;
            this.lblSkills.Location = new System.Drawing.Point(92, 378);
            this.lblSkills.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSkills.Name = "lblSkills";
            this.lblSkills.Size = new System.Drawing.Size(54, 25);
            this.lblSkills.TabIndex = 19;
            this.lblSkills.Text = "Skills";
            // 
            // HumanResources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 729);
            this.Controls.Add(this.lblSkills);
            this.Controls.Add(this.clbListOfSkills);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblDateOFBirth);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblNationalNumber);
            this.Controls.Add(this.btnCreateEmployee);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtNationalNumber);
            this.Font = new System.Drawing.Font("Mudir MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "HumanResources";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNationalNumber;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.Button btnCreateEmployee;
        private System.Windows.Forms.Label lblNationalNumber;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblDateOFBirth;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.CheckedListBox clbListOfSkills;
        private System.Windows.Forms.Label lblSkills;
    }
}

