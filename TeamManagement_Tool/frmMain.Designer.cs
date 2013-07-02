namespace TeamManagement_Tool
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Grafik");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Entwickler");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("John Riddle I", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("John Riddle II");
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabTask = new System.Windows.Forms.TabPage();
            this.btnTaskNew = new System.Windows.Forms.Button();
            this.lblTaskResponsible = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lblTaskArea = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblTaskProject = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView13 = new System.Windows.Forms.DataGridView();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AufgabeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Projekt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bereich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verantwortlicher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeadLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Beschreibung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdas = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabMitarbeiter = new System.Windows.Forms.TabPage();
            this.dgMitarbeiter = new System.Windows.Forms.DataGridView();
            this.dgMitarbeiterNummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMitarbeiterVorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMitarbeiterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMitarbeiterLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMitarbeiterStrasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMitarbeiterPLZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMitarbeiterOrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMitarbeiterRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMitarbeiterLand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMitarbeiterPermissionLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMitarbeiter = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.blaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabGenreSkills = new System.Windows.Forms.TabPage();
            this.dataGridView10 = new System.Windows.Forms.DataGridView();
            this.tabAdminSkills = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dgProjekt = new System.Windows.Forms.DataGridView();
            this.dgProjektID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProjektName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProjektGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProjektStil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProjektPlatform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProjektStartDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProjektRelease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProjektArbeitstitel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProjektNotiz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView9 = new System.Windows.Forms.DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnNewProject = new System.Windows.Forms.Button();
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.tbPrivateNote = new System.Windows.Forms.TextBox();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.statusbarConnected = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusbarLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusbarPermission = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnBugsFeedback = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView13)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.sdas.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabMitarbeiter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMitarbeiter)).BeginInit();
            this.contextMitarbeiter.SuspendLayout();
            this.tabGenreSkills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).BeginInit();
            this.tabAdminSkills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProjekt)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            this.statusbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1008, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileProperties,
            this.toolStripSeparator1,
            this.menuFileLogout,
            this.menuFileClose});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(46, 20);
            this.menuFile.Text = "Datei";
            // 
            // menuFileProperties
            // 
            this.menuFileProperties.Name = "menuFileProperties";
            this.menuFileProperties.Size = new System.Drawing.Size(148, 22);
            this.menuFileProperties.Text = "Eigenschaften";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // menuFileLogout
            // 
            this.menuFileLogout.Name = "menuFileLogout";
            this.menuFileLogout.Size = new System.Drawing.Size(148, 22);
            this.menuFileLogout.Text = "Logout";
            this.menuFileLogout.Click += new System.EventHandler(this.menuFileLogout_Click);
            // 
            // menuFileClose
            // 
            this.menuFileClose.Name = "menuFileClose";
            this.menuFileClose.Size = new System.Drawing.Size(148, 22);
            this.menuFileClose.Text = "Beenden";
            this.menuFileClose.Click += new System.EventHandler(this.menuFileClose_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpHelp,
            this.menuHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "Hilfe";
            // 
            // menuHelpHelp
            // 
            this.menuHelpHelp.Name = "menuHelpHelp";
            this.menuHelpHelp.Size = new System.Drawing.Size(99, 22);
            this.menuHelpHelp.Text = "Hilfe";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(99, 22);
            this.menuHelpAbout.Text = "Über";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabTask);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.sdas);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(5, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(795, 678);
            this.tabControl.TabIndex = 2;
            // 
            // tabTask
            // 
            this.tabTask.Controls.Add(this.btnTaskNew);
            this.tabTask.Controls.Add(this.lblTaskResponsible);
            this.tabTask.Controls.Add(this.comboBox3);
            this.tabTask.Controls.Add(this.lblTaskArea);
            this.tabTask.Controls.Add(this.comboBox2);
            this.tabTask.Controls.Add(this.lblTaskProject);
            this.tabTask.Controls.Add(this.comboBox1);
            this.tabTask.Controls.Add(this.dataGridView13);
            this.tabTask.Location = new System.Drawing.Point(4, 22);
            this.tabTask.Name = "tabTask";
            this.tabTask.Padding = new System.Windows.Forms.Padding(3);
            this.tabTask.Size = new System.Drawing.Size(787, 652);
            this.tabTask.TabIndex = 0;
            this.tabTask.Text = "Aufgaben";
            this.tabTask.UseVisualStyleBackColor = true;
            // 
            // btnTaskNew
            // 
            this.btnTaskNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaskNew.Location = new System.Drawing.Point(681, 9);
            this.btnTaskNew.Name = "btnTaskNew";
            this.btnTaskNew.Size = new System.Drawing.Size(100, 21);
            this.btnTaskNew.TabIndex = 9;
            this.btnTaskNew.Text = "Neue Aufgabe";
            this.btnTaskNew.UseVisualStyleBackColor = true;
            // 
            // lblTaskResponsible
            // 
            this.lblTaskResponsible.AutoSize = true;
            this.lblTaskResponsible.Location = new System.Drawing.Point(413, 9);
            this.lblTaskResponsible.Name = "lblTaskResponsible";
            this.lblTaskResponsible.Size = new System.Drawing.Size(83, 13);
            this.lblTaskResponsible.TabIndex = 5;
            this.lblTaskResponsible.Text = "Verantwortlicher";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(502, 6);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(150, 21);
            this.comboBox3.TabIndex = 4;
            // 
            // lblTaskArea
            // 
            this.lblTaskArea.AutoSize = true;
            this.lblTaskArea.Location = new System.Drawing.Point(208, 9);
            this.lblTaskArea.Name = "lblTaskArea";
            this.lblTaskArea.Size = new System.Drawing.Size(43, 13);
            this.lblTaskArea.TabIndex = 3;
            this.lblTaskArea.Text = "Bereich";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(257, 6);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // lblTaskProject
            // 
            this.lblTaskProject.AutoSize = true;
            this.lblTaskProject.Location = new System.Drawing.Point(6, 9);
            this.lblTaskProject.Name = "lblTaskProject";
            this.lblTaskProject.Size = new System.Drawing.Size(40, 13);
            this.lblTaskProject.TabIndex = 1;
            this.lblTaskProject.Text = "Projekt";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(52, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // dataGridView13
            // 
            this.dataGridView13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView13.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView13.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Status,
            this.Prio,
            this.Anhang,
            this.AufgabeName,
            this.Projekt,
            this.Bereich,
            this.Verantwortlicher,
            this.DeadLine,
            this.Beschreibung});
            this.dataGridView13.Location = new System.Drawing.Point(6, 37);
            this.dataGridView13.Name = "dataGridView13";
            this.dataGridView13.Size = new System.Drawing.Size(775, 609);
            this.dataGridView13.TabIndex = 7;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 30;
            // 
            // Prio
            // 
            this.Prio.HeaderText = "Prio";
            this.Prio.Name = "Prio";
            this.Prio.Width = 30;
            // 
            // Anhang
            // 
            this.Anhang.HeaderText = "Anhang";
            this.Anhang.Name = "Anhang";
            this.Anhang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Anhang.Width = 25;
            // 
            // AufgabeName
            // 
            this.AufgabeName.HeaderText = "Name";
            this.AufgabeName.Name = "AufgabeName";
            // 
            // Projekt
            // 
            this.Projekt.HeaderText = "Projekt";
            this.Projekt.Name = "Projekt";
            // 
            // Bereich
            // 
            this.Bereich.HeaderText = "Bereich";
            this.Bereich.Name = "Bereich";
            // 
            // Verantwortlicher
            // 
            this.Verantwortlicher.HeaderText = "Verantwortlicher";
            this.Verantwortlicher.Name = "Verantwortlicher";
            // 
            // DeadLine
            // 
            this.DeadLine.HeaderText = "DeadLine";
            this.DeadLine.Name = "DeadLine";
            this.DeadLine.Width = 50;
            // 
            // Beschreibung
            // 
            this.Beschreibung.HeaderText = "Beschreibung";
            this.Beschreibung.Name = "Beschreibung";
            this.Beschreibung.Width = 300;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBox5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.comboBox6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.comboBox7);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(787, 652);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Bugs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(681, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 21);
            this.button2.TabIndex = 17;
            this.button2.Text = "Neuer Bug";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Status";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(456, 6);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(150, 21);
            this.comboBox5.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Bereich";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(257, 6);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(150, 21);
            this.comboBox6.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Projekt";
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(52, 6);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(150, 21);
            this.comboBox7.TabIndex = 10;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dataGridView2.Location = new System.Drawing.Point(6, 37);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(775, 609);
            this.dataGridView2.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Status";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Prio";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 30;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Anhang";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.Width = 25;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Projekt";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Bereich";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Verantwortlicher";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "DeadLine";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 50;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Beschreibung";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 300;
            // 
            // sdas
            // 
            this.sdas.Controls.Add(this.tabControl2);
            this.sdas.Controls.Add(this.dgProjekt);
            this.sdas.Location = new System.Drawing.Point(4, 22);
            this.sdas.Name = "sdas";
            this.sdas.Padding = new System.Windows.Forms.Padding(3);
            this.sdas.Size = new System.Drawing.Size(787, 652);
            this.sdas.TabIndex = 2;
            this.sdas.Text = "OnlyEntertainment";
            this.sdas.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabMitarbeiter);
            this.tabControl2.Controls.Add(this.tabGenreSkills);
            this.tabControl2.Controls.Add(this.tabAdminSkills);
            this.tabControl2.Location = new System.Drawing.Point(-4, 228);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(791, 450);
            this.tabControl2.TabIndex = 16;
            // 
            // tabMitarbeiter
            // 
            this.tabMitarbeiter.Controls.Add(this.dgMitarbeiter);
            this.tabMitarbeiter.Location = new System.Drawing.Point(4, 22);
            this.tabMitarbeiter.Name = "tabMitarbeiter";
            this.tabMitarbeiter.Padding = new System.Windows.Forms.Padding(3);
            this.tabMitarbeiter.Size = new System.Drawing.Size(783, 424);
            this.tabMitarbeiter.TabIndex = 0;
            this.tabMitarbeiter.Text = "Mitarbeiter";
            this.tabMitarbeiter.UseVisualStyleBackColor = true;
            // 
            // dgMitarbeiter
            // 
            this.dgMitarbeiter.AllowUserToAddRows = false;
            this.dgMitarbeiter.AllowUserToDeleteRows = false;
            this.dgMitarbeiter.AllowUserToOrderColumns = true;
            this.dgMitarbeiter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgMitarbeiter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMitarbeiter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgMitarbeiterNummer,
            this.dgMitarbeiterVorname,
            this.dgMitarbeiterName,
            this.dgMitarbeiterLogin,
            this.dgMitarbeiterStrasse,
            this.dgMitarbeiterPLZ,
            this.dgMitarbeiterOrt,
            this.dgMitarbeiterRegion,
            this.dgMitarbeiterLand,
            this.dgMitarbeiterPermissionLevel});
            this.dgMitarbeiter.ContextMenuStrip = this.contextMitarbeiter;
            this.dgMitarbeiter.Location = new System.Drawing.Point(6, 6);
            this.dgMitarbeiter.MultiSelect = false;
            this.dgMitarbeiter.Name = "dgMitarbeiter";
            this.dgMitarbeiter.ReadOnly = true;
            this.dgMitarbeiter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMitarbeiter.Size = new System.Drawing.Size(771, 390);
            this.dgMitarbeiter.TabIndex = 17;
            this.dgMitarbeiter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMitarbeiter_CellClick);
            this.dgMitarbeiter.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMitarbeiter_CellDoubleClick);
            // 
            // dgMitarbeiterNummer
            // 
            this.dgMitarbeiterNummer.HeaderText = "Numer";
            this.dgMitarbeiterNummer.Name = "dgMitarbeiterNummer";
            this.dgMitarbeiterNummer.ReadOnly = true;
            // 
            // dgMitarbeiterVorname
            // 
            this.dgMitarbeiterVorname.HeaderText = "Vorname";
            this.dgMitarbeiterVorname.Name = "dgMitarbeiterVorname";
            this.dgMitarbeiterVorname.ReadOnly = true;
            // 
            // dgMitarbeiterName
            // 
            this.dgMitarbeiterName.HeaderText = "Name";
            this.dgMitarbeiterName.Name = "dgMitarbeiterName";
            this.dgMitarbeiterName.ReadOnly = true;
            // 
            // dgMitarbeiterLogin
            // 
            this.dgMitarbeiterLogin.HeaderText = "Login";
            this.dgMitarbeiterLogin.Name = "dgMitarbeiterLogin";
            this.dgMitarbeiterLogin.ReadOnly = true;
            // 
            // dgMitarbeiterStrasse
            // 
            this.dgMitarbeiterStrasse.HeaderText = "Strasse";
            this.dgMitarbeiterStrasse.Name = "dgMitarbeiterStrasse";
            this.dgMitarbeiterStrasse.ReadOnly = true;
            // 
            // dgMitarbeiterPLZ
            // 
            this.dgMitarbeiterPLZ.HeaderText = "PLZ";
            this.dgMitarbeiterPLZ.Name = "dgMitarbeiterPLZ";
            this.dgMitarbeiterPLZ.ReadOnly = true;
            // 
            // dgMitarbeiterOrt
            // 
            this.dgMitarbeiterOrt.HeaderText = "Ort";
            this.dgMitarbeiterOrt.Name = "dgMitarbeiterOrt";
            this.dgMitarbeiterOrt.ReadOnly = true;
            // 
            // dgMitarbeiterRegion
            // 
            this.dgMitarbeiterRegion.HeaderText = "Region";
            this.dgMitarbeiterRegion.Name = "dgMitarbeiterRegion";
            this.dgMitarbeiterRegion.ReadOnly = true;
            // 
            // dgMitarbeiterLand
            // 
            this.dgMitarbeiterLand.HeaderText = "Land";
            this.dgMitarbeiterLand.Name = "dgMitarbeiterLand";
            this.dgMitarbeiterLand.ReadOnly = true;
            // 
            // dgMitarbeiterPermissionLevel
            // 
            this.dgMitarbeiterPermissionLevel.HeaderText = "PermissionLevel";
            this.dgMitarbeiterPermissionLevel.Name = "dgMitarbeiterPermissionLevel";
            this.dgMitarbeiterPermissionLevel.ReadOnly = true;
            // 
            // contextMitarbeiter
            // 
            this.contextMitarbeiter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blaToolStripMenuItem,
            this.blubToolStripMenuItem});
            this.contextMitarbeiter.Name = "contextMitarbeiter";
            this.contextMitarbeiter.Size = new System.Drawing.Size(99, 48);
            // 
            // blaToolStripMenuItem
            // 
            this.blaToolStripMenuItem.Name = "blaToolStripMenuItem";
            this.blaToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.blaToolStripMenuItem.Text = "Bla";
            // 
            // blubToolStripMenuItem
            // 
            this.blubToolStripMenuItem.Name = "blubToolStripMenuItem";
            this.blubToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.blubToolStripMenuItem.Text = "Blub";
            // 
            // tabGenreSkills
            // 
            this.tabGenreSkills.Controls.Add(this.dataGridView10);
            this.tabGenreSkills.Location = new System.Drawing.Point(4, 22);
            this.tabGenreSkills.Name = "tabGenreSkills";
            this.tabGenreSkills.Padding = new System.Windows.Forms.Padding(3);
            this.tabGenreSkills.Size = new System.Drawing.Size(783, 424);
            this.tabGenreSkills.TabIndex = 1;
            this.tabGenreSkills.Text = "Genre/Skills";
            this.tabGenreSkills.UseVisualStyleBackColor = true;
            // 
            // dataGridView10
            // 
            this.dataGridView10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView10.Location = new System.Drawing.Point(6, 6);
            this.dataGridView10.Name = "dataGridView10";
            this.dataGridView10.Size = new System.Drawing.Size(771, 390);
            this.dataGridView10.TabIndex = 16;
            // 
            // tabAdminSkills
            // 
            this.tabAdminSkills.Controls.Add(this.label6);
            this.tabAdminSkills.Controls.Add(this.dataGridView3);
            this.tabAdminSkills.Location = new System.Drawing.Point(4, 22);
            this.tabAdminSkills.Name = "tabAdminSkills";
            this.tabAdminSkills.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdminSkills.Size = new System.Drawing.Size(783, 424);
            this.tabAdminSkills.TabIndex = 2;
            this.tabAdminSkills.Text = "AdminSkills";
            this.tabAdminSkills.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Skills";
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(771, 390);
            this.dataGridView3.TabIndex = 15;
            // 
            // dgProjekt
            // 
            this.dgProjekt.AllowUserToAddRows = false;
            this.dgProjekt.AllowUserToDeleteRows = false;
            this.dgProjekt.AllowUserToOrderColumns = true;
            this.dgProjekt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgProjekt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProjekt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgProjektID,
            this.dgProjektName,
            this.dgProjektGenre,
            this.dgProjektStil,
            this.dgProjektPlatform,
            this.dgProjektStartDatum,
            this.dgProjektRelease,
            this.dgProjektArbeitstitel,
            this.dgProjektNotiz});
            this.dgProjekt.Location = new System.Drawing.Point(6, 6);
            this.dgProjekt.Name = "dgProjekt";
            this.dgProjekt.ReadOnly = true;
            this.dgProjekt.Size = new System.Drawing.Size(771, 216);
            this.dgProjekt.TabIndex = 14;
            // 
            // dgProjektID
            // 
            this.dgProjektID.HeaderText = "ID";
            this.dgProjektID.Name = "dgProjektID";
            this.dgProjektID.ReadOnly = true;
            this.dgProjektID.Width = 25;
            // 
            // dgProjektName
            // 
            this.dgProjektName.HeaderText = "ProjektName";
            this.dgProjektName.Name = "dgProjektName";
            this.dgProjektName.ReadOnly = true;
            // 
            // dgProjektGenre
            // 
            this.dgProjektGenre.HeaderText = "Genre";
            this.dgProjektGenre.Name = "dgProjektGenre";
            this.dgProjektGenre.ReadOnly = true;
            // 
            // dgProjektStil
            // 
            this.dgProjektStil.HeaderText = "Stil";
            this.dgProjektStil.Name = "dgProjektStil";
            this.dgProjektStil.ReadOnly = true;
            // 
            // dgProjektPlatform
            // 
            this.dgProjektPlatform.HeaderText = "Plattform";
            this.dgProjektPlatform.Name = "dgProjektPlatform";
            this.dgProjektPlatform.ReadOnly = true;
            // 
            // dgProjektStartDatum
            // 
            this.dgProjektStartDatum.HeaderText = "StartDatum";
            this.dgProjektStartDatum.Name = "dgProjektStartDatum";
            this.dgProjektStartDatum.ReadOnly = true;
            // 
            // dgProjektRelease
            // 
            this.dgProjektRelease.HeaderText = "Release";
            this.dgProjektRelease.Name = "dgProjektRelease";
            this.dgProjektRelease.ReadOnly = true;
            // 
            // dgProjektArbeitstitel
            // 
            this.dgProjektArbeitstitel.HeaderText = "Arbeitstitel";
            this.dgProjektArbeitstitel.Name = "dgProjektArbeitstitel";
            this.dgProjektArbeitstitel.ReadOnly = true;
            // 
            // dgProjektNotiz
            // 
            this.dgProjektNotiz.HeaderText = "Notiz";
            this.dgProjektNotiz.Name = "dgProjektNotiz";
            this.dgProjektNotiz.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.textBox9);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.textBox3);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Controls.Add(this.comboBox4);
            this.tabPage4.Controls.Add(this.dataGridView5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(787, 652);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Allgemeine Infos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(706, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Suchen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox9.Location = new System.Drawing.Point(450, 314);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(250, 20);
            this.textBox9.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "FAQ";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(706, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Suchen";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(450, 9);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(250, 20);
            this.textBox3.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Infos";
            // 
            // dataGridView4
            // 
            this.dataGridView4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(6, 341);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(775, 305);
            this.dataGridView4.TabIndex = 13;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(40, 314);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 12;
            // 
            // dataGridView5
            // 
            this.dataGridView5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(6, 36);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(775, 275);
            this.dataGridView5.TabIndex = 15;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.dataGridView6);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.dataGridView9);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.btnNewProject);
            this.tabPage2.Controls.Add(this.dataGridView8);
            this.tabPage2.Controls.Add(this.treeView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(787, 652);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Administration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(515, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Leaderboard";
            // 
            // dataGridView6
            // 
            this.dataGridView6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(306, 37);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(475, 403);
            this.dataGridView6.TabIndex = 64;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(6, 399);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(294, 20);
            this.textBox8.TabIndex = 63;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(6, 373);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(294, 20);
            this.textBox7.TabIndex = 62;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(6, 347);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(294, 20);
            this.textBox6.TabIndex = 61;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 321);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(294, 20);
            this.textBox4.TabIndex = 60;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 295);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(294, 20);
            this.textBox2.TabIndex = 59;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 269);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 20);
            this.textBox1.TabIndex = 58;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(6, 243);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(294, 20);
            this.textBox5.TabIndex = 57;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(112, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 25);
            this.button4.TabIndex = 56;
            this.button4.Text = "Neu Account";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(430, 479);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "Bugs/Feedback";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 558);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Accounts";
            // 
            // dataGridView9
            // 
            this.dataGridView9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView9.Location = new System.Drawing.Point(306, 446);
            this.dataGridView9.Name = "dataGridView9";
            this.dataGridView9.Size = new System.Drawing.Size(475, 200);
            this.dataGridView9.TabIndex = 21;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(324, 6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 25);
            this.button8.TabIndex = 20;
            this.button8.Text = "Neuer Bereich";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 25);
            this.button7.TabIndex = 19;
            this.button7.Text = "Neu Lead";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btnNewProject
            // 
            this.btnNewProject.Location = new System.Drawing.Point(218, 6);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Size = new System.Drawing.Size(100, 25);
            this.btnNewProject.TabIndex = 12;
            this.btnNewProject.Text = "NeuesProjekt";
            this.btnNewProject.UseVisualStyleBackColor = true;
            this.btnNewProject.Click += new System.EventHandler(this.btnNewProject_Click);
            // 
            // dataGridView8
            // 
            this.dataGridView8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView8.Location = new System.Drawing.Point(6, 446);
            this.dataGridView8.Name = "dataGridView8";
            this.dataGridView8.Size = new System.Drawing.Size(294, 200);
            this.dataGridView8.TabIndex = 17;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(6, 37);
            this.treeView1.Name = "treeView1";
            treeNode13.Name = "Knoten2";
            treeNode13.Text = "Grafik";
            treeNode14.Name = "Knoten3";
            treeNode14.Text = "Entwickler";
            treeNode15.Name = "NOde 1";
            treeNode15.Text = "John Riddle I";
            treeNode16.Name = "Node2";
            treeNode16.Text = "John Riddle II";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16});
            this.treeView1.Size = new System.Drawing.Size(294, 200);
            this.treeView1.TabIndex = 12;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // calendar
            // 
            this.calendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.calendar.Location = new System.Drawing.Point(812, 33);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 9;
            // 
            // dataGridView7
            // 
            this.dataGridView7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Location = new System.Drawing.Point(812, 202);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.Size = new System.Drawing.Size(178, 150);
            this.dataGridView7.TabIndex = 10;
            // 
            // tbPrivateNote
            // 
            this.tbPrivateNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPrivateNote.Location = new System.Drawing.Point(812, 363);
            this.tbPrivateNote.Multiline = true;
            this.tbPrivateNote.Name = "tbPrivateNote";
            this.tbPrivateNote.Size = new System.Drawing.Size(178, 286);
            this.tbPrivateNote.TabIndex = 11;
            this.tbPrivateNote.Text = "Funktionen:\r\n- Login\r\n- Durch Button \"Bug/Feedback\" \r\n   und Programm-Start Daten" +
    " \r\n   aktualisieren\r\n  - Mitarbeiter\r\n  - Projekte";
            // 
            // statusbar
            // 
            this.statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusbarConnected,
            this.statusbarLogin,
            this.statusbarPermission});
            this.statusbar.Location = new System.Drawing.Point(0, 708);
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(1008, 22);
            this.statusbar.TabIndex = 12;
            this.statusbar.Text = "statusStrip1";
            // 
            // statusbarConnected
            // 
            this.statusbarConnected.Name = "statusbarConnected";
            this.statusbarConnected.Size = new System.Drawing.Size(65, 17);
            this.statusbarConnected.Text = "Verbunden";
            // 
            // statusbarLogin
            // 
            this.statusbarLogin.Name = "statusbarLogin";
            this.statusbarLogin.Size = new System.Drawing.Size(87, 17);
            this.statusbarLogin.Text = "-NotLoggedIn-";
            // 
            // statusbarPermission
            // 
            this.statusbarPermission.Name = "statusbarPermission";
            this.statusbarPermission.Size = new System.Drawing.Size(36, 17);
            this.statusbarPermission.Text = "None";
            // 
            // btnBugsFeedback
            // 
            this.btnBugsFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBugsFeedback.Location = new System.Drawing.Point(812, 655);
            this.btnBugsFeedback.Name = "btnBugsFeedback";
            this.btnBugsFeedback.Size = new System.Drawing.Size(178, 50);
            this.btnBugsFeedback.TabIndex = 13;
            this.btnBugsFeedback.Text = "Bugs / Feedback\r\nmelden";
            this.btnBugsFeedback.UseVisualStyleBackColor = true;
            this.btnBugsFeedback.Click += new System.EventHandler(this.btnBugsFeedback_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.btnBugsFeedback);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.dataGridView7);
            this.Controls.Add(this.tbPrivateNote);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.tabControl);
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeamManagementTool - ©OnlyEntertainment";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabTask.ResumeLayout(false);
            this.tabTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView13)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.sdas.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabMitarbeiter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMitarbeiter)).EndInit();
            this.contextMitarbeiter.ResumeLayout(false);
            this.tabGenreSkills.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).EndInit();
            this.tabAdminSkills.ResumeLayout(false);
            this.tabAdminSkills.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProjekt)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            this.statusbar.ResumeLayout(false);
            this.statusbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTask;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTaskResponsible;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label lblTaskArea;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblTaskProject;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn AufgabeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Projekt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bereich;
        private System.Windows.Forms.DataGridViewTextBoxColumn Verantwortlicher;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeadLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Beschreibung;
        private System.Windows.Forms.Button btnTaskNew;
        private System.Windows.Forms.TabPage sdas;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabMitarbeiter;
        private System.Windows.Forms.DataGridView dgMitarbeiter;
        private System.Windows.Forms.TabPage tabGenreSkills;
        private System.Windows.Forms.DataGridView dgProjekt;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.TextBox tbPrivateNote;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnNewProject;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView8;
        private System.Windows.Forms.TabPage tabAdminSkills;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.StatusStrip statusbar;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileProperties;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuFileLogout;
        private System.Windows.Forms.ToolStripMenuItem menuFileClose;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.ToolStripStatusLabel statusbarConnected;
        private System.Windows.Forms.DataGridView dataGridView10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.Button btnBugsFeedback;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel statusbarLogin;
        private System.Windows.Forms.ToolStripStatusLabel statusbarPermission;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMitarbeiterNummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMitarbeiterVorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMitarbeiterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMitarbeiterLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMitarbeiterStrasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMitarbeiterPLZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMitarbeiterOrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMitarbeiterRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMitarbeiterLand;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMitarbeiterPermissionLevel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.ContextMenuStrip contextMitarbeiter;
        private System.Windows.Forms.ToolStripMenuItem blaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blubToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProjektID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProjektName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProjektGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProjektStil;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProjektPlatform;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProjektStartDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProjektRelease;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProjektArbeitstitel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProjektNotiz;
    }
}

