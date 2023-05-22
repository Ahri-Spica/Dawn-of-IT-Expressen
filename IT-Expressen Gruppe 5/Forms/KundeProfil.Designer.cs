namespace IT_Expressen_Gruppe_5.Forms
{
    partial class KundeProfil
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tc_kundeProjekter = new System.Windows.Forms.TabControl();
            this.tc_aktiveProjekterKunde = new System.Windows.Forms.TabPage();
            this.bt_apRediger = new System.Windows.Forms.Button();
            this.bt_apSlet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_opret = new System.Windows.Forms.Button();
            this.tc_færdigeProjekterKunde = new System.Windows.Forms.TabPage();
            this.bt_fpRediger = new System.Windows.Forms.Button();
            this.bt_fpSlet = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_kundePostnummer = new System.Windows.Forms.TextBox();
            this.tb_kundeAdresse = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_kundeKommune = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_kundeBy = new System.Windows.Forms.TextBox();
            this.tb_kundeTLF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_kundeEmail = new System.Windows.Forms.TextBox();
            this.bt_save = new System.Windows.Forms.Button();
            this.tb_kundeFornavn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_kundeEfternavn = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tc_kundeProjekter.SuspendLayout();
            this.tc_aktiveProjekterKunde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tc_færdigeProjekterKunde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tb_kundePostnummer);
            this.panel1.Controls.Add(this.tb_kundeAdresse);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tb_kundeKommune);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tb_kundeBy);
            this.panel1.Controls.Add(this.tb_kundeTLF);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_kundeEmail);
            this.panel1.Controls.Add(this.bt_save);
            this.panel1.Controls.Add(this.tb_kundeFornavn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_kundeEfternavn);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 499);
            this.panel1.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tc_kundeProjekter);
            this.panel3.Location = new System.Drawing.Point(519, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(611, 339);
            this.panel3.TabIndex = 32;
            // 
            // tc_kundeProjekter
            // 
            this.tc_kundeProjekter.Controls.Add(this.tc_aktiveProjekterKunde);
            this.tc_kundeProjekter.Controls.Add(this.tc_færdigeProjekterKunde);
            this.tc_kundeProjekter.Location = new System.Drawing.Point(3, 3);
            this.tc_kundeProjekter.Name = "tc_kundeProjekter";
            this.tc_kundeProjekter.SelectedIndex = 0;
            this.tc_kundeProjekter.Size = new System.Drawing.Size(606, 333);
            this.tc_kundeProjekter.TabIndex = 33;
            // 
            // tc_aktiveProjekterKunde
            // 
            this.tc_aktiveProjekterKunde.AccessibleName = "";
            this.tc_aktiveProjekterKunde.Controls.Add(this.bt_apRediger);
            this.tc_aktiveProjekterKunde.Controls.Add(this.bt_apSlet);
            this.tc_aktiveProjekterKunde.Controls.Add(this.dataGridView1);
            this.tc_aktiveProjekterKunde.Controls.Add(this.bt_opret);
            this.tc_aktiveProjekterKunde.Location = new System.Drawing.Point(4, 29);
            this.tc_aktiveProjekterKunde.Name = "tc_aktiveProjekterKunde";
            this.tc_aktiveProjekterKunde.Padding = new System.Windows.Forms.Padding(3);
            this.tc_aktiveProjekterKunde.Size = new System.Drawing.Size(598, 300);
            this.tc_aktiveProjekterKunde.TabIndex = 0;
            this.tc_aktiveProjekterKunde.Text = "Aktive Projekter";
            this.tc_aktiveProjekterKunde.UseVisualStyleBackColor = true;
            // 
            // bt_apRediger
            // 
            this.bt_apRediger.Location = new System.Drawing.Point(375, 257);
            this.bt_apRediger.Name = "bt_apRediger";
            this.bt_apRediger.Size = new System.Drawing.Size(106, 36);
            this.bt_apRediger.TabIndex = 37;
            this.bt_apRediger.Text = "Rediger";
            this.bt_apRediger.UseVisualStyleBackColor = true;
            // 
            // bt_apSlet
            // 
            this.bt_apSlet.Location = new System.Drawing.Point(263, 257);
            this.bt_apSlet.Name = "bt_apSlet";
            this.bt_apSlet.Size = new System.Drawing.Size(106, 36);
            this.bt_apSlet.TabIndex = 35;
            this.bt_apSlet.Text = "Slet";
            this.bt_apSlet.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(598, 245);
            this.dataGridView1.TabIndex = 29;
            // 
            // bt_opret
            // 
            this.bt_opret.Location = new System.Drawing.Point(487, 257);
            this.bt_opret.Name = "bt_opret";
            this.bt_opret.Size = new System.Drawing.Size(106, 36);
            this.bt_opret.TabIndex = 34;
            this.bt_opret.Text = "Opret";
            this.bt_opret.UseVisualStyleBackColor = true;
            // 
            // tc_færdigeProjekterKunde
            // 
            this.tc_færdigeProjekterKunde.Controls.Add(this.bt_fpRediger);
            this.tc_færdigeProjekterKunde.Controls.Add(this.bt_fpSlet);
            this.tc_færdigeProjekterKunde.Controls.Add(this.dataGridView2);
            this.tc_færdigeProjekterKunde.Location = new System.Drawing.Point(4, 29);
            this.tc_færdigeProjekterKunde.Name = "tc_færdigeProjekterKunde";
            this.tc_færdigeProjekterKunde.Padding = new System.Windows.Forms.Padding(3);
            this.tc_færdigeProjekterKunde.Size = new System.Drawing.Size(598, 300);
            this.tc_færdigeProjekterKunde.TabIndex = 1;
            this.tc_færdigeProjekterKunde.Text = "Færdige Projekter";
            this.tc_færdigeProjekterKunde.UseVisualStyleBackColor = true;
            // 
            // bt_fpRediger
            // 
            this.bt_fpRediger.Location = new System.Drawing.Point(374, 258);
            this.bt_fpRediger.Name = "bt_fpRediger";
            this.bt_fpRediger.Size = new System.Drawing.Size(106, 36);
            this.bt_fpRediger.TabIndex = 39;
            this.bt_fpRediger.Text = "Rediger";
            this.bt_fpRediger.UseVisualStyleBackColor = true;
            // 
            // bt_fpSlet
            // 
            this.bt_fpSlet.Location = new System.Drawing.Point(486, 258);
            this.bt_fpSlet.Name = "bt_fpSlet";
            this.bt_fpSlet.Size = new System.Drawing.Size(106, 36);
            this.bt_fpSlet.TabIndex = 38;
            this.bt_fpSlet.Text = "Slet";
            this.bt_fpSlet.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(598, 245);
            this.dataGridView2.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Postnummer:";
            // 
            // tb_kundePostnummer
            // 
            this.tb_kundePostnummer.Location = new System.Drawing.Point(123, 248);
            this.tb_kundePostnummer.Name = "tb_kundePostnummer";
            this.tb_kundePostnummer.Size = new System.Drawing.Size(179, 26);
            this.tb_kundePostnummer.TabIndex = 6;
            // 
            // tb_kundeAdresse
            // 
            this.tb_kundeAdresse.Location = new System.Drawing.Point(123, 130);
            this.tb_kundeAdresse.Name = "tb_kundeAdresse";
            this.tb_kundeAdresse.Size = new System.Drawing.Size(179, 26);
            this.tb_kundeAdresse.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Adresse:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Kommune:";
            // 
            // tb_kundeKommune
            // 
            this.tb_kundeKommune.Location = new System.Drawing.Point(123, 168);
            this.tb_kundeKommune.Name = "tb_kundeKommune";
            this.tb_kundeKommune.Size = new System.Drawing.Size(179, 26);
            this.tb_kundeKommune.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "By:";
            // 
            // tb_kundeBy
            // 
            this.tb_kundeBy.Location = new System.Drawing.Point(123, 207);
            this.tb_kundeBy.Name = "tb_kundeBy";
            this.tb_kundeBy.Size = new System.Drawing.Size(179, 26);
            this.tb_kundeBy.TabIndex = 5;
            // 
            // tb_kundeTLF
            // 
            this.tb_kundeTLF.Location = new System.Drawing.Point(123, 368);
            this.tb_kundeTLF.Name = "tb_kundeTLF";
            this.tb_kundeTLF.Size = new System.Drawing.Size(179, 26);
            this.tb_kundeTLF.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "TLF-Nummer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Email:";
            // 
            // tb_kundeEmail
            // 
            this.tb_kundeEmail.Location = new System.Drawing.Point(123, 327);
            this.tb_kundeEmail.Name = "tb_kundeEmail";
            this.tb_kundeEmail.Size = new System.Drawing.Size(179, 26);
            this.tb_kundeEmail.TabIndex = 7;
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(15, 415);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(287, 57);
            this.bt_save.TabIndex = 0;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = true;
            // 
            // tb_kundeFornavn
            // 
            this.tb_kundeFornavn.Location = new System.Drawing.Point(123, 14);
            this.tb_kundeFornavn.Name = "tb_kundeFornavn";
            this.tb_kundeFornavn.Size = new System.Drawing.Size(179, 26);
            this.tb_kundeFornavn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fornavn:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(317, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 208);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "User145437";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Efternavn:";
            // 
            // tb_kundeEfternavn
            // 
            this.tb_kundeEfternavn.Location = new System.Drawing.Point(123, 52);
            this.tb_kundeEfternavn.Name = "tb_kundeEfternavn";
            this.tb_kundeEfternavn.Size = new System.Drawing.Size(179, 26);
            this.tb_kundeEfternavn.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IT_Expressen_Gruppe_5.Properties.Resources.Customer;
            this.pictureBox1.Location = new System.Drawing.Point(20, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // KundeProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 524);
            this.Controls.Add(this.panel1);
            this.Name = "KundeProfil";
            this.Text = "KundeProfil";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tc_kundeProjekter.ResumeLayout(false);
            this.tc_aktiveProjekterKunde.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tc_færdigeProjekterKunde.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tc_kundeProjekter;
        private System.Windows.Forms.TabPage tc_aktiveProjekterKunde;
        private System.Windows.Forms.Button bt_apRediger;
        private System.Windows.Forms.Button bt_apSlet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_opret;
        private System.Windows.Forms.TabPage tc_færdigeProjekterKunde;
        private System.Windows.Forms.Button bt_fpRediger;
        private System.Windows.Forms.Button bt_fpSlet;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_kundePostnummer;
        private System.Windows.Forms.TextBox tb_kundeAdresse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_kundeKommune;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_kundeBy;
        private System.Windows.Forms.TextBox tb_kundeTLF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_kundeEmail;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.TextBox tb_kundeFornavn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_kundeEfternavn;
    }
}