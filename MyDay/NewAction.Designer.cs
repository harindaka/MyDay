namespace MyDay
{
    partial class NewAction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAction));
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
            this.autoCompleteBox1 = new MyDay.AutoCompleteBox();
            this.label1 = new System.Windows.Forms.Label();
            this.autoCompleteBox2 = new MyDay.AutoCompleteBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.autoCompleteBox3 = new MyDay.AutoCompleteBox();
            this.label4 = new System.Windows.Forms.Label();
            this.autoCompleteBox4 = new MyDay.AutoCompleteBox();
            this.label5 = new System.Windows.Forms.Label();
            this.autoCompleteBox5 = new MyDay.AutoCompleteBox();
            this.label6 = new System.Windows.Forms.Label();
            this.autoCompleteBox6 = new MyDay.AutoCompleteBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.autoCompleteBox7 = new MyDay.AutoCompleteBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.mnuMenu.SuspendLayout();
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
            this.lblTime.Size = new System.Drawing.Size(507, 37);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appToolStripMenuItem,
            this.defineToolStripMenuItem});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuMenu.Size = new System.Drawing.Size(507, 24);
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
            // autoCompleteBox1
            // 
            this.autoCompleteBox1.AutoCompleteList = null;
            this.autoCompleteBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.autoCompleteBox1.Location = new System.Drawing.Point(124, 64);
            this.autoCompleteBox1.Name = "autoCompleteBox1";
            this.autoCompleteBox1.SearchListCaption = "Search Projects";
            this.autoCompleteBox1.Size = new System.Drawing.Size(371, 20);
            this.autoCompleteBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Project";
            // 
            // autoCompleteBox2
            // 
            this.autoCompleteBox2.AutoCompleteList = null;
            this.autoCompleteBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.autoCompleteBox2.Location = new System.Drawing.Point(124, 90);
            this.autoCompleteBox2.Name = "autoCompleteBox2";
            this.autoCompleteBox2.SearchListCaption = "Search Projects";
            this.autoCompleteBox2.Size = new System.Drawing.Size(371, 20);
            this.autoCompleteBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Task";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Task Type";
            // 
            // autoCompleteBox3
            // 
            this.autoCompleteBox3.AutoCompleteList = null;
            this.autoCompleteBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.autoCompleteBox3.Location = new System.Drawing.Point(124, 117);
            this.autoCompleteBox3.Name = "autoCompleteBox3";
            this.autoCompleteBox3.SearchListCaption = "Search Projects";
            this.autoCompleteBox3.Size = new System.Drawing.Size(371, 20);
            this.autoCompleteBox3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Task Status";
            // 
            // autoCompleteBox4
            // 
            this.autoCompleteBox4.AutoCompleteList = null;
            this.autoCompleteBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.autoCompleteBox4.Location = new System.Drawing.Point(124, 145);
            this.autoCompleteBox4.Name = "autoCompleteBox4";
            this.autoCompleteBox4.SearchListCaption = "Search Projects";
            this.autoCompleteBox4.Size = new System.Drawing.Size(371, 20);
            this.autoCompleteBox4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Estimated Effort (Hrs)";
            // 
            // autoCompleteBox5
            // 
            this.autoCompleteBox5.AutoCompleteList = null;
            this.autoCompleteBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.autoCompleteBox5.Location = new System.Drawing.Point(124, 171);
            this.autoCompleteBox5.Name = "autoCompleteBox5";
            this.autoCompleteBox5.SearchListCaption = "Search Projects";
            this.autoCompleteBox5.Size = new System.Drawing.Size(371, 20);
            this.autoCompleteBox5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Action";
            // 
            // autoCompleteBox6
            // 
            this.autoCompleteBox6.AutoCompleteList = null;
            this.autoCompleteBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.autoCompleteBox6.Location = new System.Drawing.Point(124, 199);
            this.autoCompleteBox6.Multiline = true;
            this.autoCompleteBox6.Name = "autoCompleteBox6";
            this.autoCompleteBox6.SearchListCaption = "Search Projects";
            this.autoCompleteBox6.Size = new System.Drawing.Size(371, 104);
            this.autoCompleteBox6.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Action Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 313);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(251, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "From";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(287, 313);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(381, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "To";
            // 
            // autoCompleteBox7
            // 
            this.autoCompleteBox7.AutoCompleteList = null;
            this.autoCompleteBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.autoCompleteBox7.Location = new System.Drawing.Point(124, 341);
            this.autoCompleteBox7.Name = "autoCompleteBox7";
            this.autoCompleteBox7.SearchListCaption = "Search Projects";
            this.autoCompleteBox7.Size = new System.Drawing.Size(371, 20);
            this.autoCompleteBox7.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Action Type";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(339, 383);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(420, 383);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker3.Location = new System.Drawing.Point(407, 313);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowUpDown = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker3.TabIndex = 8;
            // 
            // NewAction
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(507, 441);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.autoCompleteBox7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.autoCompleteBox6);
            this.Controls.Add(this.autoCompleteBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.autoCompleteBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.autoCompleteBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.autoCompleteBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.autoCompleteBox1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.mnuMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mnuMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewAction";
            this.ShowInTaskbar = false;
            this.Text = "New Action";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.NewAction_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewAction_FormClosing);
            this.Load += new System.EventHandler(this.NewAction_Load);
            this.Controls.SetChildIndex(this.mnuMenu, 0);
            this.Controls.SetChildIndex(this.lblTime, 0);
            this.Controls.SetChildIndex(this.autoCompleteBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.autoCompleteBox2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.autoCompleteBox3, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.autoCompleteBox4, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.autoCompleteBox5, 0);
            this.Controls.SetChildIndex(this.autoCompleteBox6, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.dateTimePicker2, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.autoCompleteBox7, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.dateTimePicker3, 0);
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
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
        private AutoCompleteBox autoCompleteBox1;
        private System.Windows.Forms.Label label1;
        private AutoCompleteBox autoCompleteBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private AutoCompleteBox autoCompleteBox3;
        private System.Windows.Forms.Label label4;
        private AutoCompleteBox autoCompleteBox4;
        private System.Windows.Forms.Label label5;
        private AutoCompleteBox autoCompleteBox5;
        private System.Windows.Forms.Label label6;
        private AutoCompleteBox autoCompleteBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label9;
        private AutoCompleteBox autoCompleteBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
    }
}
