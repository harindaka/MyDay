using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MyDay.Data;
using System.Linq;

namespace MyDay
{
    public partial class NewAction : MyDay.FormBase
    {
        bool _exitApp;

        public NewAction()
        {
            InitializeComponent();

            this.lblTime.Text = "MyDay - " + DateTime.Now.ToString("hh:mm:ss tt");

            Rectangle r = Screen.PrimaryScreen.WorkingArea;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
        }

        private void Initialize()
        {
            using (var db = new MyDayData())
            {
                var query = from p in db.Projects
                            orderby p.ProjectCode
                            select p.ProjectCode;

                autoCompleteBox1.AutoCompleteList = query.ToList();
            }
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "MyDay - " + DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _exitApp = true;
            this.Close();
        }

        private void projectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Projects form = new Projects();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void taskTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskTypes form = new TaskTypes();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void taskStatusesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskStatuses form = new TaskStatuses();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void actionTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActionTypes form = new ActionTypes();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void NewAction_Load(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private void niIcon_Click(object sender, EventArgs e)
        {
            if (this.Visible)
                this.Hide();
            else
                this.Show();
        }

        private void NewAction_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_exitApp && (e.CloseReason != CloseReason.WindowsShutDown || e.CloseReason != CloseReason.TaskManagerClosing || e.CloseReason != CloseReason.ApplicationExitCall))
            {
                e.Cancel = true;
                this.Hide();
            }
        }
        
        private void NewAction_Deactivate(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
