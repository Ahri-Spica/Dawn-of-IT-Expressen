
namespace IT_Expressen_Gruppe_5
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
            this.UseBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.testBox = new System.Windows.Forms.RichTextBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UseBox
            // 
            this.UseBox.Location = new System.Drawing.Point(108, 86);
            this.UseBox.Name = "UseBox";
            this.UseBox.Size = new System.Drawing.Size(100, 22);
            this.UseBox.TabIndex = 0;
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(108, 159);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(100, 22);
            this.PassBox.TabIndex = 1;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(108, 222);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(108, 23);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // testBox
            // 
            this.testBox.Location = new System.Drawing.Point(108, 319);
            this.testBox.Name = "testBox";
            this.testBox.Size = new System.Drawing.Size(150, 119);
            this.testBox.TabIndex = 3;
            this.testBox.Text = "";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(489, 170);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateBtn.TabIndex = 4;
            this.CreateBtn.Text = "button1";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.testBox);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.UseBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UseBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.RichTextBox testBox;
        private System.Windows.Forms.Button CreateBtn;
    }
}

