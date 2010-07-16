namespace SqlTableDiff
{
	partial class MainWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.SrcGroup = new System.Windows.Forms.GroupBox();
			this.SrcPassTxt = new System.Windows.Forms.TextBox();
			this.SrcAuthBinding = new System.Windows.Forms.BindingSource(this.components);
			this.SrcUserTxt = new System.Windows.Forms.TextBox();
			this.SrcSchemaTxt = new System.Windows.Forms.TextBox();
			this.SrcDatabaseTxt = new System.Windows.Forms.TextBox();
			this.SrcServerTxt = new System.Windows.Forms.TextBox();
			this.SrcAuthSqlOpt = new System.Windows.Forms.RadioButton();
			this.label18 = new System.Windows.Forms.Label();
			this.SrcAuthWinOpt = new System.Windows.Forms.RadioButton();
			this.label9 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.MenuBar = new System.Windows.Forms.MenuStrip();
			this.FileMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.FileExitItm = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpMnu = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpInstructItm = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpAboutItm = new System.Windows.Forms.ToolStripMenuItem();
			this.StatusBar = new System.Windows.Forms.StatusStrip();
			this.StatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
			this.DestGroup = new System.Windows.Forms.GroupBox();
			this.DestPassTxt = new System.Windows.Forms.TextBox();
			this.DestAuthBinding = new System.Windows.Forms.BindingSource(this.components);
			this.DestUserTxt = new System.Windows.Forms.TextBox();
			this.DestSchemaTxt = new System.Windows.Forms.TextBox();
			this.DestDatabaseTxt = new System.Windows.Forms.TextBox();
			this.DestServerTxt = new System.Windows.Forms.TextBox();
			this.DestAuthSqlOpt = new System.Windows.Forms.RadioButton();
			this.label17 = new System.Windows.Forms.Label();
			this.DestAuthWinOpt = new System.Windows.Forms.RadioButton();
			this.label10 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.OutGroup = new System.Windows.Forms.GroupBox();
			this.OutReportOpenBtn = new System.Windows.Forms.Button();
			this.OutFolderOpenBtn = new System.Windows.Forms.Button();
			this.OutScriptSingleFileChk = new System.Windows.Forms.CheckBox();
			this.OutFolderBtn = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.OutFolderTxt = new System.Windows.Forms.TextBox();
			this.TablesGroup = new System.Windows.Forms.GroupBox();
			this.TablesTxt = new System.Windows.Forms.TextBox();
			this.OptGroup = new System.Windows.Forms.GroupBox();
			this.OptFastCompareChk = new System.Windows.Forms.CheckBox();
			this.OptStrictSchemaChk = new System.Windows.Forms.CheckBox();
			this.OptColCompareChk = new System.Windows.Forms.CheckBox();
			this.OptRetryIntervalTxt = new System.Windows.Forms.TextBox();
			this.OptRetryCountTxt = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.OptConnectTimeoutTxt = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.OptLargeObjBytesTxt = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.ExecGroup = new System.Windows.Forms.GroupBox();
			this.ExecBtn = new System.Windows.Forms.Button();
			this.ExecInfo = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.OutFolderDlg = new System.Windows.Forms.FolderBrowserDialog();
			this.Tip = new System.Windows.Forms.ToolTip(this.components);
			this.SrcGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SrcAuthBinding)).BeginInit();
			this.MenuBar.SuspendLayout();
			this.StatusBar.SuspendLayout();
			this.DestGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DestAuthBinding)).BeginInit();
			this.OutGroup.SuspendLayout();
			this.TablesGroup.SuspendLayout();
			this.OptGroup.SuspendLayout();
			this.ExecGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// SrcGroup
			// 
			this.SrcGroup.Controls.Add(this.SrcPassTxt);
			this.SrcGroup.Controls.Add(this.SrcUserTxt);
			this.SrcGroup.Controls.Add(this.SrcSchemaTxt);
			this.SrcGroup.Controls.Add(this.SrcDatabaseTxt);
			this.SrcGroup.Controls.Add(this.SrcServerTxt);
			this.SrcGroup.Controls.Add(this.SrcAuthSqlOpt);
			this.SrcGroup.Controls.Add(this.label18);
			this.SrcGroup.Controls.Add(this.SrcAuthWinOpt);
			this.SrcGroup.Controls.Add(this.label9);
			this.SrcGroup.Controls.Add(this.label4);
			this.SrcGroup.Controls.Add(this.label3);
			this.SrcGroup.Controls.Add(this.label2);
			this.SrcGroup.Controls.Add(this.label1);
			this.SrcGroup.Location = new System.Drawing.Point(12, 27);
			this.SrcGroup.Name = "SrcGroup";
			this.SrcGroup.Size = new System.Drawing.Size(248, 189);
			this.SrcGroup.TabIndex = 0;
			this.SrcGroup.TabStop = false;
			this.SrcGroup.Text = "Source";
			// 
			// SrcPassTxt
			// 
			this.SrcPassTxt.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.SrcAuthBinding, "Checked", true, System.Windows.Forms.DataSourceUpdateMode.Never));
			this.SrcPassTxt.Location = new System.Drawing.Point(87, 99);
			this.SrcPassTxt.Name = "SrcPassTxt";
			this.SrcPassTxt.Size = new System.Drawing.Size(121, 20);
			this.SrcPassTxt.TabIndex = 8;
			this.SrcPassTxt.UseSystemPasswordChar = true;
			// 
			// SrcAuthBinding
			// 
			this.SrcAuthBinding.DataSource = typeof(System.Windows.Forms.RadioButton);
			// 
			// SrcUserTxt
			// 
			this.SrcUserTxt.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.SrcAuthBinding, "Checked", true, System.Windows.Forms.DataSourceUpdateMode.Never));
			this.SrcUserTxt.Location = new System.Drawing.Point(87, 73);
			this.SrcUserTxt.Name = "SrcUserTxt";
			this.SrcUserTxt.Size = new System.Drawing.Size(121, 20);
			this.SrcUserTxt.TabIndex = 6;
			// 
			// SrcSchemaTxt
			// 
			this.SrcSchemaTxt.Location = new System.Drawing.Point(87, 150);
			this.SrcSchemaTxt.Name = "SrcSchemaTxt";
			this.SrcSchemaTxt.Size = new System.Drawing.Size(121, 20);
			this.SrcSchemaTxt.TabIndex = 12;
			// 
			// SrcDatabaseTxt
			// 
			this.SrcDatabaseTxt.Location = new System.Drawing.Point(87, 125);
			this.SrcDatabaseTxt.Name = "SrcDatabaseTxt";
			this.SrcDatabaseTxt.Size = new System.Drawing.Size(121, 20);
			this.SrcDatabaseTxt.TabIndex = 10;
			// 
			// SrcServerTxt
			// 
			this.SrcServerTxt.Location = new System.Drawing.Point(87, 24);
			this.SrcServerTxt.Name = "SrcServerTxt";
			this.SrcServerTxt.Size = new System.Drawing.Size(121, 20);
			this.SrcServerTxt.TabIndex = 1;
			// 
			// SrcAuthSqlOpt
			// 
			this.SrcAuthSqlOpt.AutoSize = true;
			this.SrcAuthSqlOpt.Location = new System.Drawing.Point(162, 50);
			this.SrcAuthSqlOpt.Name = "SrcAuthSqlOpt";
			this.SrcAuthSqlOpt.Size = new System.Drawing.Size(46, 17);
			this.SrcAuthSqlOpt.TabIndex = 4;
			this.SrcAuthSqlOpt.Text = "SQL";
			this.SrcAuthSqlOpt.UseVisualStyleBackColor = true;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(35, 153);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(46, 13);
			this.label18.TabIndex = 11;
			this.label18.Text = "Schema";
			// 
			// SrcAuthWinOpt
			// 
			this.SrcAuthWinOpt.AutoSize = true;
			this.SrcAuthWinOpt.Checked = true;
			this.SrcAuthWinOpt.Location = new System.Drawing.Point(87, 50);
			this.SrcAuthWinOpt.Name = "SrcAuthWinOpt";
			this.SrcAuthWinOpt.Size = new System.Drawing.Size(69, 17);
			this.SrcAuthWinOpt.TabIndex = 3;
			this.SrcAuthWinOpt.TabStop = true;
			this.SrcAuthWinOpt.Text = "Windows";
			this.SrcAuthWinOpt.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(28, 128);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(53, 13);
			this.label9.TabIndex = 9;
			this.label9.Text = "Database";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.SrcAuthBinding, "Checked", true, System.Windows.Forms.DataSourceUpdateMode.Never));
			this.label4.Location = new System.Drawing.Point(28, 102);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Password";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.SrcAuthBinding, "Checked", true, System.Windows.Forms.DataSourceUpdateMode.Never));
			this.label3.Location = new System.Drawing.Point(52, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "User";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Authentication";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(43, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Server";
			// 
			// MenuBar
			// 
			this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMnu,
            this.HelpMnu});
			this.MenuBar.Location = new System.Drawing.Point(0, 0);
			this.MenuBar.Name = "MenuBar";
			this.MenuBar.Size = new System.Drawing.Size(792, 24);
			this.MenuBar.TabIndex = 1;
			this.MenuBar.Text = "menuStrip1";
			// 
			// FileMnu
			// 
			this.FileMnu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileExitItm});
			this.FileMnu.Name = "FileMnu";
			this.FileMnu.Size = new System.Drawing.Size(35, 20);
			this.FileMnu.Text = "&File";
			// 
			// FileExitItm
			// 
			this.FileExitItm.Name = "FileExitItm";
			this.FileExitItm.ShortcutKeyDisplayString = "Alt + F4";
			this.FileExitItm.Size = new System.Drawing.Size(149, 22);
			this.FileExitItm.Text = "E&xit";
			this.FileExitItm.Click += new System.EventHandler(this.FileExitItm_Click);
			// 
			// HelpMnu
			// 
			this.HelpMnu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpInstructItm,
            this.HelpAboutItm});
			this.HelpMnu.Name = "HelpMnu";
			this.HelpMnu.Size = new System.Drawing.Size(40, 20);
			this.HelpMnu.Text = "&Help";
			// 
			// HelpInstructItm
			// 
			this.HelpInstructItm.Name = "HelpInstructItm";
			this.HelpInstructItm.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.HelpInstructItm.Size = new System.Drawing.Size(161, 22);
			this.HelpInstructItm.Text = "&Instructions";
			this.HelpInstructItm.Click += new System.EventHandler(this.HelpInstructItm_Click);
			// 
			// HelpAboutItm
			// 
			this.HelpAboutItm.Name = "HelpAboutItm";
			this.HelpAboutItm.Size = new System.Drawing.Size(161, 22);
			this.HelpAboutItm.Text = "&About";
			this.HelpAboutItm.Click += new System.EventHandler(this.HelpAboutItm_Click);
			// 
			// StatusBar
			// 
			this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLbl});
			this.StatusBar.Location = new System.Drawing.Point(0, 567);
			this.StatusBar.Name = "StatusBar";
			this.StatusBar.Size = new System.Drawing.Size(792, 22);
			this.StatusBar.SizingGrip = false;
			this.StatusBar.TabIndex = 2;
			this.StatusBar.Text = "statusStrip1";
			// 
			// StatusLbl
			// 
			this.StatusLbl.Name = "StatusLbl";
			this.StatusLbl.Size = new System.Drawing.Size(777, 17);
			this.StatusLbl.Spring = true;
			this.StatusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// DestGroup
			// 
			this.DestGroup.Controls.Add(this.DestPassTxt);
			this.DestGroup.Controls.Add(this.DestUserTxt);
			this.DestGroup.Controls.Add(this.DestSchemaTxt);
			this.DestGroup.Controls.Add(this.DestDatabaseTxt);
			this.DestGroup.Controls.Add(this.DestServerTxt);
			this.DestGroup.Controls.Add(this.DestAuthSqlOpt);
			this.DestGroup.Controls.Add(this.label17);
			this.DestGroup.Controls.Add(this.DestAuthWinOpt);
			this.DestGroup.Controls.Add(this.label10);
			this.DestGroup.Controls.Add(this.label5);
			this.DestGroup.Controls.Add(this.label6);
			this.DestGroup.Controls.Add(this.label7);
			this.DestGroup.Controls.Add(this.label8);
			this.DestGroup.Location = new System.Drawing.Point(272, 27);
			this.DestGroup.Name = "DestGroup";
			this.DestGroup.Size = new System.Drawing.Size(248, 189);
			this.DestGroup.TabIndex = 1;
			this.DestGroup.TabStop = false;
			this.DestGroup.Text = "Destination";
			// 
			// DestPassTxt
			// 
			this.DestPassTxt.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.DestAuthBinding, "Checked", true, System.Windows.Forms.DataSourceUpdateMode.Never));
			this.DestPassTxt.Location = new System.Drawing.Point(87, 99);
			this.DestPassTxt.Name = "DestPassTxt";
			this.DestPassTxt.Size = new System.Drawing.Size(121, 20);
			this.DestPassTxt.TabIndex = 8;
			this.DestPassTxt.UseSystemPasswordChar = true;
			// 
			// DestAuthBinding
			// 
			this.DestAuthBinding.DataSource = typeof(System.Windows.Forms.RadioButton);
			// 
			// DestUserTxt
			// 
			this.DestUserTxt.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.DestAuthBinding, "Checked", true, System.Windows.Forms.DataSourceUpdateMode.Never));
			this.DestUserTxt.Location = new System.Drawing.Point(87, 73);
			this.DestUserTxt.Name = "DestUserTxt";
			this.DestUserTxt.Size = new System.Drawing.Size(121, 20);
			this.DestUserTxt.TabIndex = 6;
			// 
			// DestSchemaTxt
			// 
			this.DestSchemaTxt.Location = new System.Drawing.Point(87, 151);
			this.DestSchemaTxt.Name = "DestSchemaTxt";
			this.DestSchemaTxt.Size = new System.Drawing.Size(121, 20);
			this.DestSchemaTxt.TabIndex = 12;
			// 
			// DestDatabaseTxt
			// 
			this.DestDatabaseTxt.Location = new System.Drawing.Point(87, 125);
			this.DestDatabaseTxt.Name = "DestDatabaseTxt";
			this.DestDatabaseTxt.Size = new System.Drawing.Size(121, 20);
			this.DestDatabaseTxt.TabIndex = 10;
			// 
			// DestServerTxt
			// 
			this.DestServerTxt.Location = new System.Drawing.Point(87, 24);
			this.DestServerTxt.Name = "DestServerTxt";
			this.DestServerTxt.Size = new System.Drawing.Size(121, 20);
			this.DestServerTxt.TabIndex = 1;
			// 
			// DestAuthSqlOpt
			// 
			this.DestAuthSqlOpt.AutoSize = true;
			this.DestAuthSqlOpt.Location = new System.Drawing.Point(162, 50);
			this.DestAuthSqlOpt.Name = "DestAuthSqlOpt";
			this.DestAuthSqlOpt.Size = new System.Drawing.Size(46, 17);
			this.DestAuthSqlOpt.TabIndex = 4;
			this.DestAuthSqlOpt.Text = "SQL";
			this.DestAuthSqlOpt.UseVisualStyleBackColor = true;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(35, 154);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(46, 13);
			this.label17.TabIndex = 11;
			this.label17.Text = "Schema";
			// 
			// DestAuthWinOpt
			// 
			this.DestAuthWinOpt.AutoSize = true;
			this.DestAuthWinOpt.Checked = true;
			this.DestAuthWinOpt.Location = new System.Drawing.Point(87, 50);
			this.DestAuthWinOpt.Name = "DestAuthWinOpt";
			this.DestAuthWinOpt.Size = new System.Drawing.Size(69, 17);
			this.DestAuthWinOpt.TabIndex = 3;
			this.DestAuthWinOpt.TabStop = true;
			this.DestAuthWinOpt.Text = "Windows";
			this.DestAuthWinOpt.UseVisualStyleBackColor = true;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(28, 128);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(53, 13);
			this.label10.TabIndex = 9;
			this.label10.Text = "Database";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.DestAuthBinding, "Checked", true, System.Windows.Forms.DataSourceUpdateMode.Never));
			this.label5.Location = new System.Drawing.Point(28, 102);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Password";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.DestAuthBinding, "Checked", true, System.Windows.Forms.DataSourceUpdateMode.Never));
			this.label6.Location = new System.Drawing.Point(52, 76);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "User";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 52);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(75, 13);
			this.label7.TabIndex = 2;
			this.label7.Text = "Authentication";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(43, 27);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(38, 13);
			this.label8.TabIndex = 0;
			this.label8.Text = "Server";
			// 
			// OutGroup
			// 
			this.OutGroup.Controls.Add(this.OutReportOpenBtn);
			this.OutGroup.Controls.Add(this.OutFolderOpenBtn);
			this.OutGroup.Controls.Add(this.OutScriptSingleFileChk);
			this.OutGroup.Controls.Add(this.OutFolderBtn);
			this.OutGroup.Controls.Add(this.label11);
			this.OutGroup.Controls.Add(this.OutFolderTxt);
			this.OutGroup.Location = new System.Drawing.Point(532, 27);
			this.OutGroup.Name = "OutGroup";
			this.OutGroup.Size = new System.Drawing.Size(248, 189);
			this.OutGroup.TabIndex = 2;
			this.OutGroup.TabStop = false;
			this.OutGroup.Text = "Output";
			// 
			// OutReportOpenBtn
			// 
			this.OutReportOpenBtn.Location = new System.Drawing.Point(37, 123);
			this.OutReportOpenBtn.Name = "OutReportOpenBtn";
			this.OutReportOpenBtn.Size = new System.Drawing.Size(186, 23);
			this.OutReportOpenBtn.TabIndex = 5;
			this.OutReportOpenBtn.Text = "Open Report File";
			this.OutReportOpenBtn.UseVisualStyleBackColor = true;
			this.OutReportOpenBtn.Click += new System.EventHandler(this.OutReportOpenBtn_Click);
			// 
			// OutFolderOpenBtn
			// 
			this.OutFolderOpenBtn.Location = new System.Drawing.Point(37, 92);
			this.OutFolderOpenBtn.Name = "OutFolderOpenBtn";
			this.OutFolderOpenBtn.Size = new System.Drawing.Size(186, 23);
			this.OutFolderOpenBtn.TabIndex = 4;
			this.OutFolderOpenBtn.Text = "Open Output Folder";
			this.OutFolderOpenBtn.UseVisualStyleBackColor = true;
			this.OutFolderOpenBtn.Click += new System.EventHandler(this.OutFolderOpenBtn_Click);
			// 
			// OutScriptSingleFileChk
			// 
			this.OutScriptSingleFileChk.AutoSize = true;
			this.OutScriptSingleFileChk.Location = new System.Drawing.Point(50, 52);
			this.OutScriptSingleFileChk.Name = "OutScriptSingleFileChk";
			this.OutScriptSingleFileChk.Size = new System.Drawing.Size(173, 17);
			this.OutScriptSingleFileChk.TabIndex = 3;
			this.OutScriptSingleFileChk.Text = "Put all sql scripts in a single file.";
			this.OutScriptSingleFileChk.UseVisualStyleBackColor = true;
			this.OutScriptSingleFileChk.Visible = false;
			// 
			// OutFolderBtn
			// 
			this.OutFolderBtn.Location = new System.Drawing.Point(211, 24);
			this.OutFolderBtn.Name = "OutFolderBtn";
			this.OutFolderBtn.Size = new System.Drawing.Size(25, 20);
			this.OutFolderBtn.TabIndex = 2;
			this.OutFolderBtn.Text = "...";
			this.OutFolderBtn.UseVisualStyleBackColor = true;
			this.OutFolderBtn.Click += new System.EventHandler(this.OutFolderBtn_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(8, 27);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(36, 13);
			this.label11.TabIndex = 0;
			this.label11.Text = "Folder";
			// 
			// OutFolderTxt
			// 
			this.OutFolderTxt.Location = new System.Drawing.Point(50, 24);
			this.OutFolderTxt.Name = "OutFolderTxt";
			this.OutFolderTxt.Size = new System.Drawing.Size(159, 20);
			this.OutFolderTxt.TabIndex = 1;
			// 
			// TablesGroup
			// 
			this.TablesGroup.Controls.Add(this.TablesTxt);
			this.TablesGroup.Location = new System.Drawing.Point(12, 222);
			this.TablesGroup.Name = "TablesGroup";
			this.TablesGroup.Size = new System.Drawing.Size(248, 339);
			this.TablesGroup.TabIndex = 3;
			this.TablesGroup.TabStop = false;
			this.TablesGroup.Text = "Tables";
			// 
			// TablesTxt
			// 
			this.TablesTxt.Location = new System.Drawing.Point(9, 19);
			this.TablesTxt.Multiline = true;
			this.TablesTxt.Name = "TablesTxt";
			this.TablesTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TablesTxt.Size = new System.Drawing.Size(227, 308);
			this.TablesTxt.TabIndex = 0;
			// 
			// OptGroup
			// 
			this.OptGroup.Controls.Add(this.OptFastCompareChk);
			this.OptGroup.Controls.Add(this.OptStrictSchemaChk);
			this.OptGroup.Controls.Add(this.OptColCompareChk);
			this.OptGroup.Controls.Add(this.OptRetryIntervalTxt);
			this.OptGroup.Controls.Add(this.OptRetryCountTxt);
			this.OptGroup.Controls.Add(this.label15);
			this.OptGroup.Controls.Add(this.label14);
			this.OptGroup.Controls.Add(this.OptConnectTimeoutTxt);
			this.OptGroup.Controls.Add(this.label13);
			this.OptGroup.Controls.Add(this.OptLargeObjBytesTxt);
			this.OptGroup.Controls.Add(this.label12);
			this.OptGroup.Location = new System.Drawing.Point(272, 222);
			this.OptGroup.Name = "OptGroup";
			this.OptGroup.Size = new System.Drawing.Size(508, 129);
			this.OptGroup.TabIndex = 4;
			this.OptGroup.TabStop = false;
			this.OptGroup.Text = "Advanced Options";
			// 
			// OptFastCompareChk
			// 
			this.OptFastCompareChk.AutoSize = true;
			this.OptFastCompareChk.Location = new System.Drawing.Point(50, 74);
			this.OptFastCompareChk.Name = "OptFastCompareChk";
			this.OptFastCompareChk.Size = new System.Drawing.Size(104, 17);
			this.OptFastCompareChk.TabIndex = 2;
			this.OptFastCompareChk.Text = "Fast Comparison";
			this.Tip.SetToolTip(this.OptFastCompareChk, "Perform a fast comparison by only comparing row counts and schema.");
			this.OptFastCompareChk.UseVisualStyleBackColor = true;
			// 
			// OptStrictSchemaChk
			// 
			this.OptStrictSchemaChk.AutoSize = true;
			this.OptStrictSchemaChk.Location = new System.Drawing.Point(50, 48);
			this.OptStrictSchemaChk.Name = "OptStrictSchemaChk";
			this.OptStrictSchemaChk.Size = new System.Drawing.Size(150, 17);
			this.OptStrictSchemaChk.TabIndex = 1;
			this.OptStrictSchemaChk.Text = "Strict Schema Comparison";
			this.Tip.SetToolTip(this.OptStrictSchemaChk, "Specifies that the source and destination schema are strictly compared.");
			this.OptStrictSchemaChk.UseVisualStyleBackColor = true;
			// 
			// OptColCompareChk
			// 
			this.OptColCompareChk.AutoSize = true;
			this.OptColCompareChk.Location = new System.Drawing.Point(50, 22);
			this.OptColCompareChk.Name = "OptColCompareChk";
			this.OptColCompareChk.Size = new System.Drawing.Size(158, 17);
			this.OptColCompareChk.TabIndex = 0;
			this.OptColCompareChk.Text = "Compare Column Definitions";
			this.Tip.SetToolTip(this.OptColCompareChk, "Specifies the the column schemas of the table should be compared.");
			this.OptColCompareChk.UseVisualStyleBackColor = true;
			// 
			// OptRetryIntervalTxt
			// 
			this.OptRetryIntervalTxt.Location = new System.Drawing.Point(367, 97);
			this.OptRetryIntervalTxt.Name = "OptRetryIntervalTxt";
			this.OptRetryIntervalTxt.Size = new System.Drawing.Size(102, 20);
			this.OptRetryIntervalTxt.TabIndex = 10;
			this.Tip.SetToolTip(this.OptRetryIntervalTxt, "Interval, in seconds, to wait between retries.");
			// 
			// OptRetryCountTxt
			// 
			this.OptRetryCountTxt.Location = new System.Drawing.Point(367, 71);
			this.OptRetryCountTxt.Name = "OptRetryCountTxt";
			this.OptRetryCountTxt.Size = new System.Drawing.Size(102, 20);
			this.OptRetryCountTxt.TabIndex = 8;
			this.Tip.SetToolTip(this.OptRetryCountTxt, "Number of times that the utility retries a failed operation.");
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(265, 100);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(96, 13);
			this.label15.TabIndex = 9;
			this.label15.Text = "Retry Interval (sec)";
			this.Tip.SetToolTip(this.label15, "Interval, in seconds, to wait between retries.");
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(269, 74);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(92, 13);
			this.label14.TabIndex = 7;
			this.label14.Text = "Number of Retries";
			this.Tip.SetToolTip(this.label14, "Number of times that the utility retries a failed operation.");
			// 
			// OptConnectTimeoutTxt
			// 
			this.OptConnectTimeoutTxt.Location = new System.Drawing.Point(367, 45);
			this.OptConnectTimeoutTxt.Name = "OptConnectTimeoutTxt";
			this.OptConnectTimeoutTxt.Size = new System.Drawing.Size(102, 20);
			this.OptConnectTimeoutTxt.TabIndex = 6;
			this.Tip.SetToolTip(this.OptConnectTimeoutTxt, "Sets the connection timeout period, in seconds, for connections to the source ser" +
					"ver and destination server.");
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(259, 48);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(102, 13);
			this.label13.TabIndex = 5;
			this.label13.Text = "Connection Timeout";
			this.Tip.SetToolTip(this.label13, "Sets the connection timeout period, in seconds, for connections to the source ser" +
					"ver and destination server.");
			// 
			// OptLargeObjBytesTxt
			// 
			this.OptLargeObjBytesTxt.Location = new System.Drawing.Point(367, 19);
			this.OptLargeObjBytesTxt.Name = "OptLargeObjBytesTxt";
			this.OptLargeObjBytesTxt.Size = new System.Drawing.Size(102, 20);
			this.OptLargeObjBytesTxt.TabIndex = 4;
			this.Tip.SetToolTip(this.OptLargeObjBytesTxt, resources.GetString("OptLargeObjBytesTxt.ToolTip"));
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(264, 22);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(97, 13);
			this.label12.TabIndex = 3;
			this.label12.Text = "Large Object Bytes";
			this.Tip.SetToolTip(this.label12, resources.GetString("label12.ToolTip"));
			// 
			// ExecGroup
			// 
			this.ExecGroup.Controls.Add(this.ExecBtn);
			this.ExecGroup.Controls.Add(this.ExecInfo);
			this.ExecGroup.Controls.Add(this.label16);
			this.ExecGroup.Location = new System.Drawing.Point(272, 357);
			this.ExecGroup.Name = "ExecGroup";
			this.ExecGroup.Size = new System.Drawing.Size(508, 204);
			this.ExecGroup.TabIndex = 5;
			this.ExecGroup.TabStop = false;
			this.ExecGroup.Text = "Execution";
			// 
			// ExecBtn
			// 
			this.ExecBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExecBtn.Location = new System.Drawing.Point(421, 16);
			this.ExecBtn.Name = "ExecBtn";
			this.ExecBtn.Size = new System.Drawing.Size(75, 23);
			this.ExecBtn.TabIndex = 1;
			this.ExecBtn.Text = "&GO!";
			this.ExecBtn.UseVisualStyleBackColor = true;
			this.ExecBtn.Click += new System.EventHandler(this.ExecBtn_Click);
			// 
			// ExecInfo
			// 
			this.ExecInfo.Location = new System.Drawing.Point(10, 45);
			this.ExecInfo.MaxLength = 0;
			this.ExecInfo.Multiline = true;
			this.ExecInfo.Name = "ExecInfo";
			this.ExecInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.ExecInfo.Size = new System.Drawing.Size(486, 147);
			this.ExecInfo.TabIndex = 2;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.ForeColor = System.Drawing.Color.Navy;
			this.label16.Location = new System.Drawing.Point(6, 21);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(385, 13);
			this.label16.TabIndex = 0;
			this.label16.Text = "No tables will be changed. This tool simply diffs the table data (schema optional" +
				").";
			// 
			// OutFolderDlg
			// 
			this.OutFolderDlg.Description = "Choose an output folder";
			// 
			// Tip
			// 
			this.Tip.AutoPopDelay = 30000;
			this.Tip.InitialDelay = 100;
			this.Tip.ReshowDelay = 100;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(792, 589);
			this.Controls.Add(this.ExecGroup);
			this.Controls.Add(this.OptGroup);
			this.Controls.Add(this.TablesGroup);
			this.Controls.Add(this.OutGroup);
			this.Controls.Add(this.DestGroup);
			this.Controls.Add(this.StatusBar);
			this.Controls.Add(this.SrcGroup);
			this.Controls.Add(this.MenuBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.MenuBar;
			this.MaximizeBox = false;
			this.Name = "MainWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sql Table Diff";
			this.SrcGroup.ResumeLayout(false);
			this.SrcGroup.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.SrcAuthBinding)).EndInit();
			this.MenuBar.ResumeLayout(false);
			this.MenuBar.PerformLayout();
			this.StatusBar.ResumeLayout(false);
			this.StatusBar.PerformLayout();
			this.DestGroup.ResumeLayout(false);
			this.DestGroup.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DestAuthBinding)).EndInit();
			this.OutGroup.ResumeLayout(false);
			this.OutGroup.PerformLayout();
			this.TablesGroup.ResumeLayout(false);
			this.TablesGroup.PerformLayout();
			this.OptGroup.ResumeLayout(false);
			this.OptGroup.PerformLayout();
			this.ExecGroup.ResumeLayout(false);
			this.ExecGroup.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox SrcGroup;
		private System.Windows.Forms.TextBox SrcPassTxt;
		private System.Windows.Forms.TextBox SrcUserTxt;
		private System.Windows.Forms.TextBox SrcServerTxt;
		private System.Windows.Forms.RadioButton SrcAuthSqlOpt;
		private System.Windows.Forms.RadioButton SrcAuthWinOpt;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MenuStrip MenuBar;
		private System.Windows.Forms.ToolStripMenuItem FileMnu;
		private System.Windows.Forms.ToolStripMenuItem FileExitItm;
		private System.Windows.Forms.ToolStripMenuItem HelpMnu;
		private System.Windows.Forms.ToolStripMenuItem HelpAboutItm;
		private System.Windows.Forms.StatusStrip StatusBar;
		private System.Windows.Forms.GroupBox DestGroup;
		private System.Windows.Forms.TextBox DestPassTxt;
		private System.Windows.Forms.TextBox DestUserTxt;
		private System.Windows.Forms.TextBox DestServerTxt;
		private System.Windows.Forms.RadioButton DestAuthSqlOpt;
		private System.Windows.Forms.RadioButton DestAuthWinOpt;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox OutGroup;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.BindingSource SrcAuthBinding;
		private System.Windows.Forms.BindingSource DestAuthBinding;
		private System.Windows.Forms.TextBox SrcDatabaseTxt;
		private System.Windows.Forms.TextBox DestDatabaseTxt;
		private System.Windows.Forms.Button OutFolderBtn;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox OutFolderTxt;
		private System.Windows.Forms.CheckBox OutScriptSingleFileChk;
		private System.Windows.Forms.GroupBox TablesGroup;
		private System.Windows.Forms.GroupBox OptGroup;
		private System.Windows.Forms.GroupBox ExecGroup;
		private System.Windows.Forms.TextBox TablesTxt;
		private System.Windows.Forms.TextBox ExecInfo;
		private System.Windows.Forms.Button ExecBtn;
		private System.Windows.Forms.TextBox OptRetryCountTxt;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox OptConnectTimeoutTxt;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox OptLargeObjBytesTxt;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.CheckBox OptFastCompareChk;
		private System.Windows.Forms.CheckBox OptStrictSchemaChk;
		private System.Windows.Forms.CheckBox OptColCompareChk;
		private System.Windows.Forms.TextBox OptRetryIntervalTxt;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Button OutFolderOpenBtn;
		private System.Windows.Forms.TextBox SrcSchemaTxt;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox DestSchemaTxt;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.FolderBrowserDialog OutFolderDlg;
		private System.Windows.Forms.Button OutReportOpenBtn;
		private System.Windows.Forms.ToolStripStatusLabel StatusLbl;
		private System.Windows.Forms.ToolTip Tip;
		private System.Windows.Forms.ToolStripMenuItem HelpInstructItm;
	}
}

