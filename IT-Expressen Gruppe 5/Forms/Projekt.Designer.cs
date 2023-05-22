namespace IT_Expressen_Gruppe_5.Models
{
    partial class Projekt
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
            this.components = new System.ComponentModel.Container();
            this.lb_ProjektNavn = new System.Windows.Forms.Label();
            this.tb_ProjektName = new System.Windows.Forms.TextBox();
            this.lb_StartDato = new System.Windows.Forms.Label();
            this.tb_ProjektEjer = new System.Windows.Forms.TextBox();
            this.lb_ProjektEjer = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lb_SlutDato = new System.Windows.Forms.Label();
            this.tp2 = new System.Windows.Forms.TabControl();
            this.tb_konsulenter = new System.Windows.Forms.TabPage();
            this.b_chat = new System.Windows.Forms.Button();
            this.b_invitation = new System.Windows.Forms.Button();
            this.tb_chat = new System.Windows.Forms.TabPage();
            this.b_OpenChat = new System.Windows.Forms.Button();
            this.dgv_Chat = new System.Windows.Forms.DataGridView();
            this.lb_Beskrivelse = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lb_ProjektStatus = new System.Windows.Forms.Label();
            this.clb_Requirements = new System.Windows.Forms.CheckedListBox();
            this._2_sem_gr_5DataSet1 = new IT_Expressen_Gruppe_5.Database._2_sem_gr_5DataSet1();
            this.konsulentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.konsulentTableAdapter = new IT_Expressen_Gruppe_5.Database._2_sem_gr_5DataSet1TableAdapters.konsulentTableAdapter();
            this.konsulentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_konsulenter = new System.Windows.Forms.DataGridView();
            this.tp2.SuspendLayout();
            this.tb_konsulenter.SuspendLayout();
            this.tb_chat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Chat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._2_sem_gr_5DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.konsulentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.konsulentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_konsulenter)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_ProjektNavn
            // 
            this.lb_ProjektNavn.AutoSize = true;
            this.lb_ProjektNavn.Location = new System.Drawing.Point(13, 28);
            this.lb_ProjektNavn.Name = "lb_ProjektNavn";
            this.lb_ProjektNavn.Size = new System.Drawing.Size(49, 16);
            this.lb_ProjektNavn.TabIndex = 0;
            this.lb_ProjektNavn.Text = "Projekt";
            // 
            // tb_ProjektName
            // 
            this.tb_ProjektName.Location = new System.Drawing.Point(108, 25);
            this.tb_ProjektName.Name = "tb_ProjektName";
            this.tb_ProjektName.Size = new System.Drawing.Size(200, 22);
            this.tb_ProjektName.TabIndex = 1;
            // 
            // lb_StartDato
            // 
            this.lb_StartDato.AutoSize = true;
            this.lb_StartDato.Location = new System.Drawing.Point(18, 136);
            this.lb_StartDato.Name = "lb_StartDato";
            this.lb_StartDato.Size = new System.Drawing.Size(66, 16);
            this.lb_StartDato.TabIndex = 2;
            this.lb_StartDato.Text = "Start Dato";
            // 
            // tb_ProjektEjer
            // 
            this.tb_ProjektEjer.Location = new System.Drawing.Point(108, 53);
            this.tb_ProjektEjer.Name = "tb_ProjektEjer";
            this.tb_ProjektEjer.Size = new System.Drawing.Size(200, 22);
            this.tb_ProjektEjer.TabIndex = 5;
            // 
            // lb_ProjektEjer
            // 
            this.lb_ProjektEjer.AutoSize = true;
            this.lb_ProjektEjer.Location = new System.Drawing.Point(13, 56);
            this.lb_ProjektEjer.Name = "lb_ProjektEjer";
            this.lb_ProjektEjer.Size = new System.Drawing.Size(76, 16);
            this.lb_ProjektEjer.TabIndex = 4;
            this.lb_ProjektEjer.Text = "Projekt Ejer";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(112, 136);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(112, 164);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // lb_SlutDato
            // 
            this.lb_SlutDato.AutoSize = true;
            this.lb_SlutDato.Location = new System.Drawing.Point(18, 164);
            this.lb_SlutDato.Name = "lb_SlutDato";
            this.lb_SlutDato.Size = new System.Drawing.Size(61, 16);
            this.lb_SlutDato.TabIndex = 9;
            this.lb_SlutDato.Text = "Slut Dato";
            // 
            // tp2
            // 
            this.tp2.Controls.Add(this.tb_konsulenter);
            this.tp2.Controls.Add(this.tb_chat);
            this.tp2.Location = new System.Drawing.Point(314, 12);
            this.tp2.Name = "tp2";
            this.tp2.SelectedIndex = 0;
            this.tp2.Size = new System.Drawing.Size(825, 345);
            this.tp2.TabIndex = 11;
            // 
            // tb_konsulenter
            // 
            this.tb_konsulenter.Controls.Add(this.dgv_konsulenter);
            this.tb_konsulenter.Controls.Add(this.b_chat);
            this.tb_konsulenter.Controls.Add(this.b_invitation);
            this.tb_konsulenter.Location = new System.Drawing.Point(4, 25);
            this.tb_konsulenter.Name = "tb_konsulenter";
            this.tb_konsulenter.Padding = new System.Windows.Forms.Padding(3);
            this.tb_konsulenter.Size = new System.Drawing.Size(817, 316);
            this.tb_konsulenter.TabIndex = 0;
            this.tb_konsulenter.Text = "Konsulenter";
            this.tb_konsulenter.UseVisualStyleBackColor = true;
            // 
            // b_chat
            // 
            this.b_chat.Location = new System.Drawing.Point(437, 284);
            this.b_chat.Name = "b_chat";
            this.b_chat.Size = new System.Drawing.Size(88, 26);
            this.b_chat.TabIndex = 1;
            this.b_chat.Text = "Chat";
            this.b_chat.UseVisualStyleBackColor = true;
            // 
            // b_invitation
            // 
            this.b_invitation.Location = new System.Drawing.Point(326, 284);
            this.b_invitation.Name = "b_invitation";
            this.b_invitation.Size = new System.Drawing.Size(88, 26);
            this.b_invitation.TabIndex = 0;
            this.b_invitation.Text = "Invitere";
            this.b_invitation.UseVisualStyleBackColor = true;
            // 
            // tb_chat
            // 
            this.tb_chat.Controls.Add(this.b_OpenChat);
            this.tb_chat.Controls.Add(this.dgv_Chat);
            this.tb_chat.Location = new System.Drawing.Point(4, 25);
            this.tb_chat.Name = "tb_chat";
            this.tb_chat.Padding = new System.Windows.Forms.Padding(3);
            this.tb_chat.Size = new System.Drawing.Size(817, 316);
            this.tb_chat.TabIndex = 1;
            this.tb_chat.Text = "Chat";
            this.tb_chat.UseVisualStyleBackColor = true;
            // 
            // b_OpenChat
            // 
            this.b_OpenChat.Location = new System.Drawing.Point(360, 284);
            this.b_OpenChat.Name = "b_OpenChat";
            this.b_OpenChat.Size = new System.Drawing.Size(88, 26);
            this.b_OpenChat.TabIndex = 1;
            this.b_OpenChat.Text = "Åben Chat";
            this.b_OpenChat.UseVisualStyleBackColor = true;
            // 
            // dgv_Chat
            // 
            this.dgv_Chat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Chat.Location = new System.Drawing.Point(6, 7);
            this.dgv_Chat.Name = "dgv_Chat";
            this.dgv_Chat.RowHeadersWidth = 51;
            this.dgv_Chat.RowTemplate.Height = 24;
            this.dgv_Chat.Size = new System.Drawing.Size(805, 270);
            this.dgv_Chat.TabIndex = 0;
            // 
            // lb_Beskrivelse
            // 
            this.lb_Beskrivelse.AutoSize = true;
            this.lb_Beskrivelse.Location = new System.Drawing.Point(92, 223);
            this.lb_Beskrivelse.Name = "lb_Beskrivelse";
            this.lb_Beskrivelse.Size = new System.Drawing.Size(123, 16);
            this.lb_Beskrivelse.TabIndex = 12;
            this.lb_Beskrivelse.Text = "Projekt Beskrivelse";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 242);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 422);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 22);
            this.textBox2.TabIndex = 15;
            // 
            // lb_ProjektStatus
            // 
            this.lb_ProjektStatus.AutoSize = true;
            this.lb_ProjektStatus.Location = new System.Drawing.Point(17, 111);
            this.lb_ProjektStatus.Name = "lb_ProjektStatus";
            this.lb_ProjektStatus.Size = new System.Drawing.Size(89, 16);
            this.lb_ProjektStatus.TabIndex = 14;
            this.lb_ProjektStatus.Text = "Projekt Status";
            // 
            // clb_Requirements
            // 
            this.clb_Requirements.FormattingEnabled = true;
            this.clb_Requirements.Items.AddRange(new object[] {
            "test1 ",
            "test2"});
            this.clb_Requirements.Location = new System.Drawing.Point(314, 363);
            this.clb_Requirements.Name = "clb_Requirements";
            this.clb_Requirements.Size = new System.Drawing.Size(820, 293);
            this.clb_Requirements.TabIndex = 16;
            // 
            // _2_sem_gr_5DataSet1
            // 
            this._2_sem_gr_5DataSet1.DataSetName = "_2_sem_gr_5DataSet1";
            this._2_sem_gr_5DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // konsulentBindingSource
            // 
            this.konsulentBindingSource.DataMember = "konsulent";
            this.konsulentBindingSource.DataSource = this._2_sem_gr_5DataSet1;
            // 
            // konsulentTableAdapter
            // 
            this.konsulentTableAdapter.ClearBeforeFill = true;
            // 
            // konsulentBindingSource1
            // 
            this.konsulentBindingSource1.DataMember = "konsulent";
            this.konsulentBindingSource1.DataSource = this._2_sem_gr_5DataSet1;
            // 
            // dgv_konsulenter
            // 
            this.dgv_konsulenter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_konsulenter.Location = new System.Drawing.Point(6, 6);
            this.dgv_konsulenter.Name = "dgv_konsulenter";
            this.dgv_konsulenter.RowHeadersWidth = 51;
            this.dgv_konsulenter.RowTemplate.Height = 24;
            this.dgv_konsulenter.Size = new System.Drawing.Size(805, 272);
            this.dgv_konsulenter.TabIndex = 2;
            // 
            // Projekt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 726);
            this.Controls.Add(this.clb_Requirements);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lb_ProjektStatus);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_Beskrivelse);
            this.Controls.Add(this.tp2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.lb_SlutDato);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tb_ProjektEjer);
            this.Controls.Add(this.lb_ProjektEjer);
            this.Controls.Add(this.lb_StartDato);
            this.Controls.Add(this.tb_ProjektName);
            this.Controls.Add(this.lb_ProjektNavn);
            this.Name = "Projekt";
            this.Text = "Projekt";
            this.Load += new System.EventHandler(this.Projekt_Load);
            this.tp2.ResumeLayout(false);
            this.tb_konsulenter.ResumeLayout(false);
            this.tb_chat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Chat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._2_sem_gr_5DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.konsulentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.konsulentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_konsulenter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ProjektNavn;
        private System.Windows.Forms.Label lb_StartDato;
        private System.Windows.Forms.Label lb_ProjektEjer;
        public System.Windows.Forms.TextBox tb_ProjektName;
        public System.Windows.Forms.TextBox tb_ProjektEjer;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lb_SlutDato;
        private System.Windows.Forms.TabPage tb_konsulenter;
        private System.Windows.Forms.Label lb_Beskrivelse;
        public System.Windows.Forms.TabControl tp2;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lb_ProjektStatus;
        public System.Windows.Forms.Button b_OpenChat;
        public System.Windows.Forms.DataGridView dgv_Chat;
        public System.Windows.Forms.Button b_invitation;
        public System.Windows.Forms.TabPage tb_chat;
        public System.Windows.Forms.Button b_chat;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.CheckedListBox clb_Requirements;
        private Database._2_sem_gr_5DataSet1 _2_sem_gr_5DataSet1;
        private System.Windows.Forms.BindingSource konsulentBindingSource;
        private Database._2_sem_gr_5DataSet1TableAdapters.konsulentTableAdapter konsulentTableAdapter;
        private System.Windows.Forms.BindingSource konsulentBindingSource1;
        private System.Windows.Forms.DataGridView dgv_konsulenter;
    }
}