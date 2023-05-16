
namespace IT_Expressen_Gruppe_5.Forms
{
    partial class RegisterForm
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
            this.RegisterTabCtrl = new System.Windows.Forms.TabControl();
            this.CustomerTab = new System.Windows.Forms.TabPage();
            this.maskedPhoneBox = new System.Windows.Forms.MaskedTextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.AdressLbl = new System.Windows.Forms.Label();
            this.PhoneLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.AdressBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.ConsultantTab = new System.Windows.Forms.TabPage();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Admin = new System.Windows.Forms.TabPage();
            this.maskedAdminPhoneBox = new System.Windows.Forms.MaskedTextBox();
            this.AdminSubmitBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AdminAdressBox = new System.Windows.Forms.TextBox();
            this.AdminNameBox = new System.Windows.Forms.TextBox();
            this.RegisterTabCtrl.SuspendLayout();
            this.CustomerTab.SuspendLayout();
            this.ConsultantTab.SuspendLayout();
            this.Admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterTabCtrl
            // 
            this.RegisterTabCtrl.Controls.Add(this.CustomerTab);
            this.RegisterTabCtrl.Controls.Add(this.ConsultantTab);
            this.RegisterTabCtrl.Controls.Add(this.Admin);
            this.RegisterTabCtrl.Location = new System.Drawing.Point(82, 37);
            this.RegisterTabCtrl.Name = "RegisterTabCtrl";
            this.RegisterTabCtrl.RightToLeftLayout = true;
            this.RegisterTabCtrl.SelectedIndex = 0;
            this.RegisterTabCtrl.Size = new System.Drawing.Size(535, 381);
            this.RegisterTabCtrl.TabIndex = 0;
            // 
            // CustomerTab
            // 
            this.CustomerTab.Controls.Add(this.maskedPhoneBox);
            this.CustomerTab.Controls.Add(this.SubmitBtn);
            this.CustomerTab.Controls.Add(this.AdressLbl);
            this.CustomerTab.Controls.Add(this.PhoneLbl);
            this.CustomerTab.Controls.Add(this.NameLbl);
            this.CustomerTab.Controls.Add(this.AdressBox);
            this.CustomerTab.Controls.Add(this.NameBox);
            this.CustomerTab.Location = new System.Drawing.Point(4, 25);
            this.CustomerTab.Name = "CustomerTab";
            this.CustomerTab.Padding = new System.Windows.Forms.Padding(3);
            this.CustomerTab.Size = new System.Drawing.Size(527, 352);
            this.CustomerTab.TabIndex = 0;
            this.CustomerTab.Text = "Customer";
            this.CustomerTab.UseVisualStyleBackColor = true;
            // 
            // maskedPhoneBox
            // 
            this.maskedPhoneBox.Location = new System.Drawing.Point(70, 128);
            this.maskedPhoneBox.Mask = "00000000";
            this.maskedPhoneBox.Name = "maskedPhoneBox";
            this.maskedPhoneBox.Size = new System.Drawing.Size(100, 22);
            this.maskedPhoneBox.TabIndex = 7;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(70, 235);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(100, 23);
            this.SubmitBtn.TabIndex = 6;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // AdressLbl
            // 
            this.AdressLbl.AutoSize = true;
            this.AdressLbl.Location = new System.Drawing.Point(67, 159);
            this.AdressLbl.Name = "AdressLbl";
            this.AdressLbl.Size = new System.Drawing.Size(52, 17);
            this.AdressLbl.TabIndex = 5;
            this.AdressLbl.Text = "Adress";
            this.AdressLbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // PhoneLbl
            // 
            this.PhoneLbl.AutoSize = true;
            this.PhoneLbl.Location = new System.Drawing.Point(67, 108);
            this.PhoneLbl.Name = "PhoneLbl";
            this.PhoneLbl.Size = new System.Drawing.Size(64, 17);
            this.PhoneLbl.TabIndex = 4;
            this.PhoneLbl.Text = "PhoneNr";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(67, 57);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(45, 17);
            this.NameLbl.TabIndex = 3;
            this.NameLbl.Text = "Name";
            // 
            // AdressBox
            // 
            this.AdressBox.Location = new System.Drawing.Point(70, 179);
            this.AdressBox.Name = "AdressBox";
            this.AdressBox.Size = new System.Drawing.Size(100, 22);
            this.AdressBox.TabIndex = 2;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(70, 77);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 22);
            this.NameBox.TabIndex = 0;
            // 
            // ConsultantTab
            // 
            this.ConsultantTab.Controls.Add(this.maskedTextBox1);
            this.ConsultantTab.Controls.Add(this.button1);
            this.ConsultantTab.Controls.Add(this.label1);
            this.ConsultantTab.Controls.Add(this.label2);
            this.ConsultantTab.Controls.Add(this.label3);
            this.ConsultantTab.Controls.Add(this.textBox1);
            this.ConsultantTab.Controls.Add(this.textBox2);
            this.ConsultantTab.Location = new System.Drawing.Point(4, 25);
            this.ConsultantTab.Name = "ConsultantTab";
            this.ConsultantTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConsultantTab.Size = new System.Drawing.Size(527, 352);
            this.ConsultantTab.TabIndex = 1;
            this.ConsultantTab.Text = "Consultant";
            this.ConsultantTab.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(70, 128);
            this.maskedTextBox1.Mask = "00000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "PhoneNr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 8;
            // 
            // Admin
            // 
            this.Admin.Controls.Add(this.maskedAdminPhoneBox);
            this.Admin.Controls.Add(this.AdminSubmitBtn);
            this.Admin.Controls.Add(this.label4);
            this.Admin.Controls.Add(this.label5);
            this.Admin.Controls.Add(this.label6);
            this.Admin.Controls.Add(this.AdminAdressBox);
            this.Admin.Controls.Add(this.AdminNameBox);
            this.Admin.Location = new System.Drawing.Point(4, 25);
            this.Admin.Name = "Admin";
            this.Admin.Padding = new System.Windows.Forms.Padding(3);
            this.Admin.Size = new System.Drawing.Size(527, 352);
            this.Admin.TabIndex = 2;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = true;
            // 
            // maskedAdminPhoneBox
            // 
            this.maskedAdminPhoneBox.Location = new System.Drawing.Point(70, 128);
            this.maskedAdminPhoneBox.Mask = "00000000";
            this.maskedAdminPhoneBox.Name = "maskedAdminPhoneBox";
            this.maskedAdminPhoneBox.Size = new System.Drawing.Size(100, 22);
            this.maskedAdminPhoneBox.TabIndex = 14;
            // 
            // AdminSubmitBtn
            // 
            this.AdminSubmitBtn.Location = new System.Drawing.Point(70, 235);
            this.AdminSubmitBtn.Name = "AdminSubmitBtn";
            this.AdminSubmitBtn.Size = new System.Drawing.Size(100, 23);
            this.AdminSubmitBtn.TabIndex = 13;
            this.AdminSubmitBtn.Text = "Submit";
            this.AdminSubmitBtn.UseVisualStyleBackColor = true;
            this.AdminSubmitBtn.Click += new System.EventHandler(this.AdminSubmitBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Adress";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "PhoneNr";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Name";
            // 
            // AdminAdressBox
            // 
            this.AdminAdressBox.Location = new System.Drawing.Point(70, 179);
            this.AdminAdressBox.Name = "AdminAdressBox";
            this.AdminAdressBox.Size = new System.Drawing.Size(100, 22);
            this.AdminAdressBox.TabIndex = 9;
            // 
            // AdminNameBox
            // 
            this.AdminNameBox.Location = new System.Drawing.Point(70, 77);
            this.AdminNameBox.Name = "AdminNameBox";
            this.AdminNameBox.Size = new System.Drawing.Size(100, 22);
            this.AdminNameBox.TabIndex = 8;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegisterTabCtrl);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.RegisterTabCtrl.ResumeLayout(false);
            this.CustomerTab.ResumeLayout(false);
            this.CustomerTab.PerformLayout();
            this.ConsultantTab.ResumeLayout(false);
            this.ConsultantTab.PerformLayout();
            this.Admin.ResumeLayout(false);
            this.Admin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl RegisterTabCtrl;
        private System.Windows.Forms.TabPage CustomerTab;
        private System.Windows.Forms.TabPage ConsultantTab;
        private System.Windows.Forms.TabPage Admin;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox AdressBox;
        private System.Windows.Forms.Label AdressLbl;
        private System.Windows.Forms.Label PhoneLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.MaskedTextBox maskedPhoneBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MaskedTextBox maskedAdminPhoneBox;
        private System.Windows.Forms.Button AdminSubmitBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AdminAdressBox;
        private System.Windows.Forms.TextBox AdminNameBox;
    }
}