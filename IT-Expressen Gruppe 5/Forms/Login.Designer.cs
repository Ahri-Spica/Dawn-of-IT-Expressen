
namespace IT_Expressen_Gruppe_5
{
    partial class Login
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
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.b_Login = new System.Windows.Forms.Button();
            this.testBox = new System.Windows.Forms.RichTextBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_ErrorMessage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Username
            // 
            this.tb_Username.Location = new System.Drawing.Point(55, 90);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(100, 22);
            this.tb_Username.TabIndex = 0;
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(55, 163);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(100, 22);
            this.tb_Password.TabIndex = 1;
            // 
            // b_Login
            // 
            this.b_Login.Location = new System.Drawing.Point(55, 226);
            this.b_Login.Name = "b_Login";
            this.b_Login.Size = new System.Drawing.Size(108, 23);
            this.b_Login.TabIndex = 2;
            this.b_Login.Text = "Login";
            this.b_Login.UseVisualStyleBackColor = true;
            this.b_Login.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // testBox
            // 
            this.testBox.Location = new System.Drawing.Point(26, 89);
            this.testBox.Name = "testBox";
            this.testBox.Size = new System.Drawing.Size(176, 213);
            this.testBox.TabIndex = 3;
            this.testBox.Text = "";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(26, 26);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(108, 23);
            this.CreateBtn.TabIndex = 4;
            this.CreateBtn.Text = "Register User";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_ErrorMessage);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.b_Login);
            this.panel1.Controls.Add(this.tb_Password);
            this.panel1.Controls.Add(this.tb_Username);
            this.panel1.Location = new System.Drawing.Point(28, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 329);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CreateBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.testBox);
            this.panel2.Location = new System.Drawing.Point(292, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 328);
            this.panel2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Test Data";
            // 
            // lb_ErrorMessage
            // 
            this.lb_ErrorMessage.AutoSize = true;
            this.lb_ErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lb_ErrorMessage.Location = new System.Drawing.Point(3, 278);
            this.lb_ErrorMessage.Name = "lb_ErrorMessage";
            this.lb_ErrorMessage.Size = new System.Drawing.Size(44, 16);
            this.lb_ErrorMessage.TabIndex = 7;
            this.lb_ErrorMessage.Text = "label4";
            // 
            // Login
            // 
            this.AcceptButton = this.b_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 390);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button b_Login;
        private System.Windows.Forms.RichTextBox testBox;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tb_Username;
        public System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lb_ErrorMessage;
    }
}

