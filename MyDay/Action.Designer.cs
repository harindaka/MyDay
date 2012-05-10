namespace MyDay
{
    partial class Action
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Action));
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.appToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskStatusesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtProject = new MyDay.AutoCompleteBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTask = new MyDay.AutoCompleteBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaskType = new MyDay.AutoCompleteBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTaskStatus = new MyDay.AutoCompleteBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEstEffort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAction = new MyDay.AutoCompleteBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpActionDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpActionTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtActionType = new MyDay.AutoCompleteBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpActionTimeTo = new System.Windows.Forms.DateTimePicker();
            this.pnlFields = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtActionTags = new MyDay.AutoCompleteBox();
            this.tpTags = new MyDay.TagPanel();
            this.lblActionCode = new System.Windows.Forms.Label();
            this.pbNewAction = new System.Windows.Forms.PictureBox();
            this.pbNewActionType = new System.Windows.Forms.PictureBox();
            this.pbNewTaskStatus = new System.Windows.Forms.PictureBox();
            this.pbNewTaskType = new System.Windows.Forms.PictureBox();
            this.pbNewTask = new System.Windows.Forms.PictureBox();
            this.pbNewProject = new System.Windows.Forms.PictureBox();
            this.mnuMenu.SuspendLayout();
            this.pnlFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewActionType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewTaskStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewTaskType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewProject)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // lblTime
            // 
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTime.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTime.Location = new System.Drawing.Point(0, 24);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(515, 22);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appToolStripMenuItem,
            this.defineToolStripMenuItem});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuMenu.Size = new System.Drawing.Size(515, 24);
            this.mnuMenu.TabIndex = 2;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // appToolStripMenuItem
            // 
            this.appToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimizeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.appToolStripMenuItem.Name = "appToolStripMenuItem";
            this.appToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.appToolStripMenuItem.Text = "App";
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.minimizeToolStripMenuItem.Text = "Minimize";
            this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.minimizeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // defineToolStripMenuItem
            // 
            this.defineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectsToolStripMenuItem,
            this.taskTypesToolStripMenuItem,
            this.taskStatusesToolStripMenuItem,
            this.actionTypesToolStripMenuItem});
            this.defineToolStripMenuItem.Name = "defineToolStripMenuItem";
            this.defineToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.defineToolStripMenuItem.Text = "Define";
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.projectsToolStripMenuItem.Text = "Projects";
            this.projectsToolStripMenuItem.Click += new System.EventHandler(this.projectsToolStripMenuItem_Click);
            // 
            // taskTypesToolStripMenuItem
            // 
            this.taskTypesToolStripMenuItem.Name = "taskTypesToolStripMenuItem";
            this.taskTypesToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.taskTypesToolStripMenuItem.Text = "Task Types";
            this.taskTypesToolStripMenuItem.Click += new System.EventHandler(this.taskTypesToolStripMenuItem_Click);
            // 
            // taskStatusesToolStripMenuItem
            // 
            this.taskStatusesToolStripMenuItem.Name = "taskStatusesToolStripMenuItem";
            this.taskStatusesToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.taskStatusesToolStripMenuItem.Text = "Task Statuses";
            this.taskStatusesToolStripMenuItem.Click += new System.EventHandler(this.taskStatusesToolStripMenuItem_Click);
            // 
            // actionTypesToolStripMenuItem
            // 
            this.actionTypesToolStripMenuItem.Name = "actionTypesToolStripMenuItem";
            this.actionTypesToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.actionTypesToolStripMenuItem.Text = "Action Types";
            this.actionTypesToolStripMenuItem.Click += new System.EventHandler(this.actionTypesToolStripMenuItem_Click);
            // 
            // niIcon
            // 
            this.niIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("niIcon.Icon")));
            this.niIcon.Text = "MyDay";
            this.niIcon.Visible = true;
            this.niIcon.Click += new System.EventHandler(this.niIcon_Click);
            // 
            // txtProject
            // 
            this.txtProject.AutoCompleteList = null;
            this.txtProject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProject.Location = new System.Drawing.Point(127, 13);
            this.txtProject.MaxLength = 100;
            this.txtProject.Name = "txtProject";
            this.txtProject.SearchListCaption = "Search Projects";
            this.txtProject.Size = new System.Drawing.Size(336, 20);
            this.txtProject.TabIndex = 0;
            this.txtProject.Search += new AutoCompleteBox.SearchEventHandler(this.txtFields_Search);
            this.txtProject.SearchComplete += new System.EventHandler(this.txtFields_SearchComplete);
            this.txtProject.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFields_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Project*";
            // 
            // txtTask
            // 
            this.txtTask.AutoCompleteList = null;
            this.txtTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTask.Location = new System.Drawing.Point(127, 39);
            this.txtTask.MaxLength = 100;
            this.txtTask.Name = "txtTask";
            this.txtTask.SearchListCaption = "Search Tasks";
            this.txtTask.Size = new System.Drawing.Size(336, 20);
            this.txtTask.TabIndex = 1;
            this.txtTask.Search += new AutoCompleteBox.SearchEventHandler(this.txtFields_Search);
            this.txtTask.SearchComplete += new System.EventHandler(this.txtFields_SearchComplete);
            this.txtTask.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFields_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Task*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Task Type*";
            // 
            // txtTaskType
            // 
            this.txtTaskType.AutoCompleteList = null;
            this.txtTaskType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaskType.Location = new System.Drawing.Point(127, 66);
            this.txtTaskType.MaxLength = 100;
            this.txtTaskType.Name = "txtTaskType";
            this.txtTaskType.SearchListCaption = "Search Task Types";
            this.txtTaskType.Size = new System.Drawing.Size(336, 20);
            this.txtTaskType.TabIndex = 2;
            this.txtTaskType.Search += new AutoCompleteBox.SearchEventHandler(this.txtFields_Search);
            this.txtTaskType.SearchComplete += new System.EventHandler(this.txtFields_SearchComplete);
            this.txtTaskType.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFields_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Task Status*";
            // 
            // txtTaskStatus
            // 
            this.txtTaskStatus.AutoCompleteList = null;
            this.txtTaskStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaskStatus.Location = new System.Drawing.Point(127, 94);
            this.txtTaskStatus.MaxLength = 100;
            this.txtTaskStatus.Name = "txtTaskStatus";
            this.txtTaskStatus.SearchListCaption = "Search Task Statuses";
            this.txtTaskStatus.Size = new System.Drawing.Size(336, 20);
            this.txtTaskStatus.TabIndex = 3;
            this.txtTaskStatus.Search += new AutoCompleteBox.SearchEventHandler(this.txtFields_Search);
            this.txtTaskStatus.SearchComplete += new System.EventHandler(this.txtFields_SearchComplete);
            this.txtTaskStatus.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFields_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Estimated Effort (Hrs)";
            // 
            // txtEstEffort
            // 
            this.txtEstEffort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstEffort.Location = new System.Drawing.Point(127, 120);
            this.txtEstEffort.MaxLength = 4;
            this.txtEstEffort.Name = "txtEstEffort";
            this.txtEstEffort.Size = new System.Drawing.Size(336, 20);
            this.txtEstEffort.TabIndex = 4;
            this.txtEstEffort.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFields_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Action*";
            // 
            // txtAction
            // 
            this.txtAction.AutoCompleteList = null;
            this.txtAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAction.Location = new System.Drawing.Point(127, 148);
            this.txtAction.MaxLength = 500;
            this.txtAction.Multiline = true;
            this.txtAction.Name = "txtAction";
            this.txtAction.SearchListCaption = "Search Actions";
            this.txtAction.Size = new System.Drawing.Size(336, 104);
            this.txtAction.TabIndex = 5;
            this.txtAction.Search += new AutoCompleteBox.SearchEventHandler(this.txtFields_Search);
            this.txtAction.SearchComplete += new System.EventHandler(this.txtFields_SearchComplete);
            this.txtAction.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFields_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Action Date*";
            // 
            // dtpActionDate
            // 
            this.dtpActionDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpActionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpActionDate.Location = new System.Drawing.Point(127, 262);
            this.dtpActionDate.Name = "dtpActionDate";
            this.dtpActionDate.Size = new System.Drawing.Size(121, 20);
            this.dtpActionDate.TabIndex = 6;
            this.dtpActionDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFields_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "From";
            // 
            // dtpActionTimeFrom
            // 
            this.dtpActionTimeFrom.CustomFormat = "";
            this.dtpActionTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpActionTimeFrom.Location = new System.Drawing.Point(290, 262);
            this.dtpActionTimeFrom.Name = "dtpActionTimeFrom";
            this.dtpActionTimeFrom.ShowUpDown = true;
            this.dtpActionTimeFrom.Size = new System.Drawing.Size(88, 20);
            this.dtpActionTimeFrom.TabIndex = 7;
            this.dtpActionTimeFrom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFields_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(384, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "To";
            // 
            // txtActionType
            // 
            this.txtActionType.AutoCompleteList = null;
            this.txtActionType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtActionType.Location = new System.Drawing.Point(127, 290);
            this.txtActionType.MaxLength = 100;
            this.txtActionType.Name = "txtActionType";
            this.txtActionType.SearchListCaption = "Search Action Types";
            this.txtActionType.Size = new System.Drawing.Size(336, 20);
            this.txtActionType.TabIndex = 9;
            this.txtActionType.Search += new AutoCompleteBox.SearchEventHandler(this.txtFields_Search);
            this.txtActionType.SearchComplete += new System.EventHandler(this.txtFields_SearchComplete);
            this.txtActionType.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFields_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Action Type*";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(347, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(428, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtpActionTimeTo
            // 
            this.dtpActionTimeTo.CustomFormat = "";
            this.dtpActionTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpActionTimeTo.Location = new System.Drawing.Point(410, 262);
            this.dtpActionTimeTo.Name = "dtpActionTimeTo";
            this.dtpActionTimeTo.ShowUpDown = true;
            this.dtpActionTimeTo.Size = new System.Drawing.Size(88, 20);
            this.dtpActionTimeTo.TabIndex = 8;
            this.dtpActionTimeTo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFields_KeyUp);
            // 
            // pnlFields
            // 
            this.pnlFields.Controls.Add(this.label11);
            this.pnlFields.Controls.Add(this.txtActionTags);
            this.pnlFields.Controls.Add(this.tpTags);
            this.pnlFields.Controls.Add(this.lblActionCode);
            this.pnlFields.Controls.Add(this.pbNewAction);
            this.pnlFields.Controls.Add(this.label1);
            this.pnlFields.Controls.Add(this.pbNewActionType);
            this.pnlFields.Controls.Add(this.txtProject);
            this.pnlFields.Controls.Add(this.pbNewTaskStatus);
            this.pnlFields.Controls.Add(this.txtTask);
            this.pnlFields.Controls.Add(this.pbNewTaskType);
            this.pnlFields.Controls.Add(this.label2);
            this.pnlFields.Controls.Add(this.pbNewTask);
            this.pnlFields.Controls.Add(this.txtTaskType);
            this.pnlFields.Controls.Add(this.pbNewProject);
            this.pnlFields.Controls.Add(this.label3);
            this.pnlFields.Controls.Add(this.dtpActionTimeTo);
            this.pnlFields.Controls.Add(this.txtTaskStatus);
            this.pnlFields.Controls.Add(this.btnCancel);
            this.pnlFields.Controls.Add(this.label4);
            this.pnlFields.Controls.Add(this.btnSave);
            this.pnlFields.Controls.Add(this.label5);
            this.pnlFields.Controls.Add(this.txtActionType);
            this.pnlFields.Controls.Add(this.txtEstEffort);
            this.pnlFields.Controls.Add(this.label10);
            this.pnlFields.Controls.Add(this.txtAction);
            this.pnlFields.Controls.Add(this.label9);
            this.pnlFields.Controls.Add(this.label6);
            this.pnlFields.Controls.Add(this.dtpActionTimeFrom);
            this.pnlFields.Controls.Add(this.label7);
            this.pnlFields.Controls.Add(this.label8);
            this.pnlFields.Controls.Add(this.dtpActionDate);
            this.pnlFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFields.Location = new System.Drawing.Point(0, 46);
            this.pnlFields.Name = "pnlFields";
            this.pnlFields.Size = new System.Drawing.Size(515, 451);
            this.pnlFields.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Action Tags";
            // 
            // txtActionTags
            // 
            this.txtActionTags.AutoCompleteList = null;
            this.txtActionTags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtActionTags.Location = new System.Drawing.Point(127, 316);
            this.txtActionTags.MaxLength = 100;
            this.txtActionTags.Name = "txtActionTags";
            this.txtActionTags.SearchListCaption = "Search Action Types";
            this.txtActionTags.Size = new System.Drawing.Size(336, 20);
            this.txtActionTags.TabIndex = 10;
            this.txtActionTags.Search += new AutoCompleteBox.SearchEventHandler(this.txtFields_Search);
            this.txtActionTags.SearchComplete += new System.EventHandler(this.txtFields_SearchComplete);
            this.txtActionTags.EnabledChanged += new System.EventHandler(this.txtActionTags_EnabledChanged);
            this.txtActionTags.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFields_KeyUp);
            // 
            // tpTags
            // 
            this.tpTags.AutoScroll = true;
            this.tpTags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpTags.Location = new System.Drawing.Point(18, 342);
            this.tpTags.Name = "tpTags";
            this.tpTags.Size = new System.Drawing.Size(445, 67);
            this.tpTags.TabIndex = 31;
            // 
            // lblActionCode
            // 
            this.lblActionCode.AutoSize = true;
            this.lblActionCode.Location = new System.Drawing.Point(58, 150);
            this.lblActionCode.Name = "lblActionCode";
            this.lblActionCode.Size = new System.Drawing.Size(35, 13);
            this.lblActionCode.TabIndex = 30;
            this.lblActionCode.Text = "(New)";
            // 
            // pbNewAction
            // 
            this.pbNewAction.Image = global::MyDay.Properties.Resources.new1;
            this.pbNewAction.Location = new System.Drawing.Point(469, 148);
            this.pbNewAction.Name = "pbNewAction";
            this.pbNewAction.Size = new System.Drawing.Size(29, 20);
            this.pbNewAction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNewAction.TabIndex = 29;
            this.pbNewAction.TabStop = false;
            // 
            // pbNewActionType
            // 
            this.pbNewActionType.Image = global::MyDay.Properties.Resources.new1;
            this.pbNewActionType.Location = new System.Drawing.Point(469, 290);
            this.pbNewActionType.Name = "pbNewActionType";
            this.pbNewActionType.Size = new System.Drawing.Size(29, 20);
            this.pbNewActionType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNewActionType.TabIndex = 28;
            this.pbNewActionType.TabStop = false;
            // 
            // pbNewTaskStatus
            // 
            this.pbNewTaskStatus.Image = global::MyDay.Properties.Resources.new1;
            this.pbNewTaskStatus.Location = new System.Drawing.Point(469, 94);
            this.pbNewTaskStatus.Name = "pbNewTaskStatus";
            this.pbNewTaskStatus.Size = new System.Drawing.Size(29, 20);
            this.pbNewTaskStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNewTaskStatus.TabIndex = 26;
            this.pbNewTaskStatus.TabStop = false;
            // 
            // pbNewTaskType
            // 
            this.pbNewTaskType.Image = global::MyDay.Properties.Resources.new1;
            this.pbNewTaskType.Location = new System.Drawing.Point(469, 66);
            this.pbNewTaskType.Name = "pbNewTaskType";
            this.pbNewTaskType.Size = new System.Drawing.Size(29, 20);
            this.pbNewTaskType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNewTaskType.TabIndex = 25;
            this.pbNewTaskType.TabStop = false;
            // 
            // pbNewTask
            // 
            this.pbNewTask.Image = global::MyDay.Properties.Resources.new1;
            this.pbNewTask.Location = new System.Drawing.Point(469, 39);
            this.pbNewTask.Name = "pbNewTask";
            this.pbNewTask.Size = new System.Drawing.Size(29, 20);
            this.pbNewTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNewTask.TabIndex = 24;
            this.pbNewTask.TabStop = false;
            // 
            // pbNewProject
            // 
            this.pbNewProject.Image = global::MyDay.Properties.Resources.new1;
            this.pbNewProject.Location = new System.Drawing.Point(469, 13);
            this.pbNewProject.Name = "pbNewProject";
            this.pbNewProject.Size = new System.Drawing.Size(29, 20);
            this.pbNewProject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNewProject.TabIndex = 23;
            this.pbNewProject.TabStop = false;
            // 
            // Action
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(515, 519);
            this.Controls.Add(this.pnlFields);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.mnuMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mnuMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Action";
            this.ShowInTaskbar = false;
            this.Text = "Action";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.NewAction_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewAction_FormClosing);
            this.Load += new System.EventHandler(this.NewAction_Load);
            this.Controls.SetChildIndex(this.mnuMenu, 0);
            this.Controls.SetChildIndex(this.lblTime, 0);
            this.Controls.SetChildIndex(this.pnlFields, 0);
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.pnlFields.ResumeLayout(false);
            this.pnlFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewActionType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewTaskStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewTaskType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewProject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem appToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskStatusesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionTypesToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon niIcon;
        private AutoCompleteBox txtProject;
        private System.Windows.Forms.Label label1;
        private AutoCompleteBox txtTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private AutoCompleteBox txtTaskType;
        private System.Windows.Forms.Label label4;
        private AutoCompleteBox txtTaskStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEstEffort;
        private System.Windows.Forms.Label label6;
        private AutoCompleteBox txtAction;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpActionDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpActionTimeFrom;
        private System.Windows.Forms.Label label9;
        private AutoCompleteBox txtActionType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpActionTimeTo;
        private System.Windows.Forms.PictureBox pbNewProject;
        private System.Windows.Forms.PictureBox pbNewTask;
        private System.Windows.Forms.PictureBox pbNewTaskType;
        private System.Windows.Forms.PictureBox pbNewTaskStatus;
        private System.Windows.Forms.PictureBox pbNewActionType;
        private System.Windows.Forms.Panel pnlFields;
        private System.Windows.Forms.PictureBox pbNewAction;
        private System.Windows.Forms.Label lblActionCode;
        private TagPanel tpTags;
        private System.Windows.Forms.Label label11;
        private AutoCompleteBox txtActionTags;
    }
}
