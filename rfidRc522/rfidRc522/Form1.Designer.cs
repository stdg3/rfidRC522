namespace rfidRc522
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxSerials = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDC = new System.Windows.Forms.Button();
            this.buttonConn = new System.Windows.Forms.Button();
            this.timer1gibi = new System.Windows.Forms.Timer(this.components);
            this.serialPortArd = new System.IO.Ports.SerialPort(this.components);
            this.labelMessage = new System.Windows.Forms.Label();
            this.textBoxConsole = new System.Windows.Forms.TextBox();
            this.buttonSetDB = new System.Windows.Forms.Button();
            this.labelDBdir = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxCardId = new System.Windows.Forms.TextBox();
            this.textBoxAdSad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonYeniKayit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCardId = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSerials
            // 
            this.comboBoxSerials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSerials.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(24)))));
            this.comboBoxSerials.FormattingEnabled = true;
            this.comboBoxSerials.Location = new System.Drawing.Point(16, 19);
            this.comboBoxSerials.Name = "comboBoxSerials";
            this.comboBoxSerials.Size = new System.Drawing.Size(184, 21);
            this.comboBoxSerials.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDC);
            this.groupBox1.Controls.Add(this.buttonConn);
            this.groupBox1.Controls.Add(this.comboBoxSerials);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(24)))));
            this.groupBox1.Location = new System.Drawing.Point(35, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 115);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port Info";
            // 
            // buttonDC
            // 
            this.buttonDC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
            this.buttonDC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(24)))));
            this.buttonDC.Location = new System.Drawing.Point(111, 57);
            this.buttonDC.Name = "buttonDC";
            this.buttonDC.Size = new System.Drawing.Size(89, 32);
            this.buttonDC.TabIndex = 2;
            this.buttonDC.Text = "DisConnect";
            this.buttonDC.UseVisualStyleBackColor = false;
            this.buttonDC.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonConn
            // 
            this.buttonConn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(242)))), ((int)(((byte)(40)))));
            this.buttonConn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(24)))));
            this.buttonConn.Location = new System.Drawing.Point(16, 57);
            this.buttonConn.Name = "buttonConn";
            this.buttonConn.Size = new System.Drawing.Size(89, 32);
            this.buttonConn.TabIndex = 1;
            this.buttonConn.Text = "Connect";
            this.buttonConn.UseVisualStyleBackColor = false;
            this.buttonConn.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1gibi
            // 
            this.timer1gibi.Tick += new System.EventHandler(this.timer1gibi_Tick);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(44, 158);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(16, 13);
            this.labelMessage.TabIndex = 2;
            this.labelMessage.Text = "...";
            // 
            // textBoxConsole
            // 
            this.textBoxConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(24)))));
            this.textBoxConsole.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(242)))), ((int)(((byte)(40)))));
            this.textBoxConsole.Location = new System.Drawing.Point(31, 200);
            this.textBoxConsole.Multiline = true;
            this.textBoxConsole.Name = "textBoxConsole";
            this.textBoxConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxConsole.Size = new System.Drawing.Size(534, 112);
            this.textBoxConsole.TabIndex = 3;
            this.textBoxConsole.Text = "KLU:/RFID Terminal";
            // 
            // buttonSetDB
            // 
            this.buttonSetDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(242)))), ((int)(((byte)(40)))));
            this.buttonSetDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(24)))));
            this.buttonSetDB.Location = new System.Drawing.Point(162, 138);
            this.buttonSetDB.Name = "buttonSetDB";
            this.buttonSetDB.Size = new System.Drawing.Size(89, 32);
            this.buttonSetDB.TabIndex = 3;
            this.buttonSetDB.Text = "Set DB";
            this.buttonSetDB.UseVisualStyleBackColor = false;
            this.buttonSetDB.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelDBdir
            // 
            this.labelDBdir.AutoSize = true;
            this.labelDBdir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(24)))));
            this.labelDBdir.Location = new System.Drawing.Point(32, 184);
            this.labelDBdir.Name = "labelDBdir";
            this.labelDBdir.Size = new System.Drawing.Size(100, 13);
            this.labelDBdir.TabIndex = 4;
            this.labelDBdir.Text = "xml yolu tanımlayınız";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(242)))), ((int)(((byte)(40)))));
            this.button1.Enabled = false;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(24)))));
            this.button1.Location = new System.Drawing.Point(6, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 22);
            this.button1.TabIndex = 3;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBoxCardId
            // 
            this.textBoxCardId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(24)))));
            this.textBoxCardId.Location = new System.Drawing.Point(80, 16);
            this.textBoxCardId.Name = "textBoxCardId";
            this.textBoxCardId.Size = new System.Drawing.Size(147, 20);
            this.textBoxCardId.TabIndex = 5;
            // 
            // textBoxAdSad
            // 
            this.textBoxAdSad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(24)))));
            this.textBoxAdSad.Location = new System.Drawing.Point(80, 57);
            this.textBoxAdSad.Name = "textBoxAdSad";
            this.textBoxAdSad.Size = new System.Drawing.Size(147, 20);
            this.textBoxAdSad.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.buttonYeniKayit);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.labelCardId);
            this.groupBox2.Controls.Add(this.textBoxCardId);
            this.groupBox2.Controls.Add(this.textBoxAdSad);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(24)))));
            this.groupBox2.Location = new System.Drawing.Point(327, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 159);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Kayıt";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
            this.checkBox1.Location = new System.Drawing.Point(9, 97);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(214, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Id ve Personel Bilgileri boş geçilmemiştir.";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonYeniKayit
            // 
            this.buttonYeniKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(242)))), ((int)(((byte)(40)))));
            this.buttonYeniKayit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(24)))));
            this.buttonYeniKayit.Location = new System.Drawing.Point(80, 121);
            this.buttonYeniKayit.Name = "buttonYeniKayit";
            this.buttonYeniKayit.Size = new System.Drawing.Size(147, 32);
            this.buttonYeniKayit.TabIndex = 5;
            this.buttonYeniKayit.Text = "Kaydet";
            this.buttonYeniKayit.UseVisualStyleBackColor = false;
            this.buttonYeniKayit.Click += new System.EventHandler(this.buttonYeniKayit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Adı Soyadı";
            // 
            // labelCardId
            // 
            this.labelCardId.AutoSize = true;
            this.labelCardId.Location = new System.Drawing.Point(6, 19);
            this.labelCardId.Name = "labelCardId";
            this.labelCardId.Size = new System.Drawing.Size(43, 13);
            this.labelCardId.TabIndex = 7;
            this.labelCardId.Text = "Card ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-3, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 331);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(571, -5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 331);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(242)))), ((int)(((byte)(40)))));
            this.button2.Enabled = false;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(24)))));
            this.button2.Location = new System.Drawing.Point(327, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "Set DB";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 324);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelDBdir);
            this.Controls.Add(this.buttonSetDB);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.textBoxConsole);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "KLU EEM RFID";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSerials;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDC;
        private System.Windows.Forms.Button buttonConn;
        private System.Windows.Forms.Timer timer1gibi;
        private System.IO.Ports.SerialPort serialPortArd;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.TextBox textBoxConsole;
        private System.Windows.Forms.Button buttonSetDB;
        private System.Windows.Forms.Label labelDBdir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxCardId;
        private System.Windows.Forms.TextBox textBoxAdSad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonYeniKayit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCardId;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
    }
}

