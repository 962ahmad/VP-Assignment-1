namespace AD1263_Assignment_1
{
    partial class Form1
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
            this.lblChooseControl = new System.Windows.Forms.Label();
            this.cbChooseControl = new System.Windows.Forms.ComboBox();
            this.lblControlNumber = new System.Windows.Forms.Label();
            this.txtNumberOfControls = new System.Windows.Forms.TextBox();
            this.p1 = new System.Windows.Forms.Panel();
            this.lblCreateControls = new System.Windows.Forms.Label();
            this.btnCreateControls = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChooseControl
            // 
            this.lblChooseControl.AutoSize = true;
            this.lblChooseControl.Location = new System.Drawing.Point(113, 110);
            this.lblChooseControl.Name = "lblChooseControl";
            this.lblChooseControl.Size = new System.Drawing.Size(79, 13);
            this.lblChooseControl.TabIndex = 13;
            this.lblChooseControl.Text = "Choose Control";
            // 
            // cbChooseControl
            // 
            this.cbChooseControl.FormattingEnabled = true;
            this.cbChooseControl.Items.AddRange(new object[] {
            "Button",
            "TextBox",
            "Label"});
            this.cbChooseControl.Location = new System.Drawing.Point(216, 107);
            this.cbChooseControl.Name = "cbChooseControl";
            this.cbChooseControl.Size = new System.Drawing.Size(212, 21);
            this.cbChooseControl.TabIndex = 12;
            // 
            // lblControlNumber
            // 
            this.lblControlNumber.AutoSize = true;
            this.lblControlNumber.Location = new System.Drawing.Point(113, 80);
            this.lblControlNumber.Name = "lblControlNumber";
            this.lblControlNumber.Size = new System.Drawing.Size(97, 13);
            this.lblControlNumber.TabIndex = 11;
            this.lblControlNumber.Text = "Number of Controls";
            // 
            // txtNumberOfControls
            // 
            this.txtNumberOfControls.Location = new System.Drawing.Point(216, 77);
            this.txtNumberOfControls.Name = "txtNumberOfControls";
            this.txtNumberOfControls.Size = new System.Drawing.Size(212, 20);
            this.txtNumberOfControls.TabIndex = 10;
            // 
            // p1
            // 
            this.p1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p1.Location = new System.Drawing.Point(462, 44);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(226, 362);
            this.p1.TabIndex = 9;
            // 
            // lblCreateControls
            // 
            this.lblCreateControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreateControls.AutoSize = true;
            this.lblCreateControls.Location = new System.Drawing.Point(113, 49);
            this.lblCreateControls.Name = "lblCreateControls";
            this.lblCreateControls.Size = new System.Drawing.Size(74, 13);
            this.lblCreateControls.TabIndex = 8;
            this.lblCreateControls.Text = "Create Control";
            // 
            // btnCreateControls
            // 
            this.btnCreateControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateControls.Location = new System.Drawing.Point(216, 44);
            this.btnCreateControls.Name = "btnCreateControls";
            this.btnCreateControls.Size = new System.Drawing.Size(212, 23);
            this.btnCreateControls.TabIndex = 7;
            this.btnCreateControls.Text = "Create Controls";
            this.btnCreateControls.UseVisualStyleBackColor = true;
            this.btnCreateControls.Click += new System.EventHandler(this.btnCreateControls_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblChooseControl);
            this.Controls.Add(this.cbChooseControl);
            this.Controls.Add(this.lblControlNumber);
            this.Controls.Add(this.txtNumberOfControls);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.lblCreateControls);
            this.Controls.Add(this.btnCreateControls);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChooseControl;
        private System.Windows.Forms.ComboBox cbChooseControl;
        private System.Windows.Forms.Label lblControlNumber;
        private System.Windows.Forms.TextBox txtNumberOfControls;
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Label lblCreateControls;
        private System.Windows.Forms.Button btnCreateControls;
    }
}

