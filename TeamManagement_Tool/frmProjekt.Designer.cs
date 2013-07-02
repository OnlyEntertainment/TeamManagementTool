namespace TeamManagement_Tool
{
    partial class frmProjekt
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbStil = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPlatform = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbArbeitstitel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNotiz = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCharCount = new System.Windows.Forms.Label();
            this.tbRelease = new System.Windows.Forms.TextBox();
            this.tbStartDatum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(85, 6);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(30, 20);
            this.tbID.TabIndex = 99;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(85, 32);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 20);
            this.tbName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(85, 58);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(200, 20);
            this.tbGenre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Genre";
            // 
            // tbStil
            // 
            this.tbStil.Location = new System.Drawing.Point(85, 84);
            this.tbStil.Name = "tbStil";
            this.tbStil.Size = new System.Drawing.Size(200, 20);
            this.tbStil.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stil";
            // 
            // tbPlatform
            // 
            this.tbPlatform.Location = new System.Drawing.Point(85, 110);
            this.tbPlatform.Name = "tbPlatform";
            this.tbPlatform.Size = new System.Drawing.Size(200, 20);
            this.tbPlatform.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Platform";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "StartDatum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Release";
            // 
            // tbArbeitstitel
            // 
            this.tbArbeitstitel.Location = new System.Drawing.Point(85, 188);
            this.tbArbeitstitel.Name = "tbArbeitstitel";
            this.tbArbeitstitel.Size = new System.Drawing.Size(200, 20);
            this.tbArbeitstitel.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Arbeitstitel";
            // 
            // tbNotiz
            // 
            this.tbNotiz.Location = new System.Drawing.Point(85, 214);
            this.tbNotiz.MaxLength = 255;
            this.tbNotiz.Multiline = true;
            this.tbNotiz.Name = "tbNotiz";
            this.tbNotiz.Size = new System.Drawing.Size(200, 100);
            this.tbNotiz.TabIndex = 7;
            this.tbNotiz.TextChanged += new System.EventHandler(this.tbNotiz_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Notiz";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(160, 320);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "S&chließen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "&Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCharCount
            // 
            this.lblCharCount.AutoSize = true;
            this.lblCharCount.Location = new System.Drawing.Point(12, 263);
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.Size = new System.Drawing.Size(36, 13);
            this.lblCharCount.TabIndex = 20;
            this.lblCharCount.Text = "1/255";
            // 
            // tbRelease
            // 
            this.tbRelease.Location = new System.Drawing.Point(85, 162);
            this.tbRelease.Name = "tbRelease";
            this.tbRelease.Size = new System.Drawing.Size(200, 20);
            this.tbRelease.TabIndex = 5;
            // 
            // tbStartDatum
            // 
            this.tbStartDatum.Location = new System.Drawing.Point(85, 139);
            this.tbStartDatum.Name = "tbStartDatum";
            this.tbStartDatum.Size = new System.Drawing.Size(200, 20);
            this.tbStartDatum.TabIndex = 4;
            // 
            // frmProjekt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 362);
            this.Controls.Add(this.tbStartDatum);
            this.Controls.Add(this.tbRelease);
            this.Controls.Add(this.lblCharCount);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbNotiz);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbArbeitstitel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPlatform);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbStil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbGenre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label1);
            this.Name = "frmProjekt";
            this.Text = "TMT - Projekt ©OE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbID;
        public System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbStil;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbPlatform;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tbArbeitstitel;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox tbNotiz;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCharCount;
        public System.Windows.Forms.TextBox tbRelease;
        public System.Windows.Forms.TextBox tbStartDatum;
    }
}