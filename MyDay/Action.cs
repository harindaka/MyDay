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
    public partial class Action : MyDay.FormBase
    {
        bool _exitApp;
        bool _keepActive;

        public Action()
        {
            InitializeComponent();

            this.lblTime.Text = "MyDay - " + DateTime.Now.ToString("hh:mm:ss tt");

            Rectangle r = Screen.PrimaryScreen.WorkingArea;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
        }

        private void Initialize()
        {
            this.ResetControls();
        }

        private Control GetNextControl(Control ctrl)
        {
            if (ctrl == txtProject)
                return txtTask;
            else if (ctrl == txtTask)
                return txtTaskType;
            else if (ctrl == txtTaskType)
                return txtTaskStatus;
            else if (ctrl == txtTaskStatus)
                return txtEstEffort;
            else if (ctrl == txtEstEffort)
                return txtAction;
            else if (ctrl == txtAction)
                return dtpActionDate;
            else if (ctrl == dtpActionDate)
                return dtpActionTimeFrom;
            else if (ctrl == dtpActionTimeFrom)
                return dtpActionTimeTo;
            else if (ctrl == dtpActionTimeTo)
                return txtActionType;
            else if (ctrl == txtActionType)
                return btnSave;
            else if (ctrl == btnSave)
                return txtProject;

            return null;
        }

        private void MoveToNextControl(Control currentControl, PictureBox newPic = null)
        {
            Control nextCtrl = this.GetNextControl(currentControl);
            nextCtrl.Enabled = true;
            nextCtrl.Focus();
            if (nextCtrl is TextBox)
                ((TextBox)nextCtrl).SelectAll();

            currentControl.Enabled = false;

            if (newPic != null)
                newPic.Visible = true;

            this.SetStatus(String.Empty);
        }

        private void ResetControls(bool sameProject = false)
        {
            using (var db = new MyDayData())
            {
                var projectQuery = from t in db.Projects
                                   orderby t.ProjectCode
                                   select t.ProjectCode;

                txtProject.AutoCompleteList = projectQuery.ToList();

                var taskTypeQuery = from t in db.TaskTypes
                                    orderby t.TaskTypeCode
                                    select t.TaskTypeCode;

                txtTaskType.AutoCompleteList = taskTypeQuery.ToList();

                var taskStatusQuery = from t in db.TaskStatuses
                                      orderby t.TaskStatusCode
                                      select t.TaskStatusCode;

                txtTaskStatus.AutoCompleteList = taskStatusQuery.ToList();

                var actionTypeQuery = from t in db.ActionTypes
                                      orderby t.ActionTypeCode
                                      select t.ActionTypeCode;

                txtActionType.AutoCompleteList = actionTypeQuery.ToList();
            }

            foreach (Control ctrl in this.pnlFields.Controls)
            {
                if (!(ctrl is Label))
                {
                    ctrl.Enabled = false;
                    if (ctrl is TextBox && !(sameProject && ctrl == txtProject))
                        ctrl.Text = String.Empty;
                    else if (ctrl is PictureBox)
                        ctrl.Visible = false;
                }
            }

            dtpActionTimeFrom.Value = dtpActionTimeTo.Value;
            btnCancel.Enabled = true;
            lblActionCode.Text = "(New)";

            this.SetStatus("Tip: Hit Up Arrow Key to select/search existing values.");

            txtProject.Enabled = true;
            txtProject.Focus();

            this.txtFields_KeyUp(txtProject, new KeyEventArgs(Keys.Enter));
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
            if (!_keepActive)
                this.Hide();
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtFields_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (sender is TextBox)
                {
                    TextBox ctrl = (TextBox)sender;
                    string val = ctrl.Text.Trim();

                    PictureBox newPic = null;

                    if (ctrl == txtProject)
                    {
                        if (String.IsNullOrEmpty(val))
                            return;

                        using (MyDayData db = new MyDayData())
                        {
                            var query = from t in db.Projects
                                        where t.ProjectCode.Equals(val, StringComparison.InvariantCultureIgnoreCase)
                                        select t;

                            var row = query.FirstOrDefault();
                            if (row == null)
                            {
                                newPic = pbNewProject;
                                txtTask.AutoCompleteList = null;
                            }
                            else
                            {
                                ctrl.Text = row.ProjectCode;

                                var tasksQuery = from t in db.Tasks
                                                 where t.ProjectCode.Equals(val, StringComparison.InvariantCultureIgnoreCase)
                                                 orderby t.TaskCode
                                                 select t.TaskCode;

                                txtTask.AutoCompleteList = tasksQuery.ToList();
                            }
                        }
                    }
                    else if (ctrl == txtTask)
                    {
                        if (String.IsNullOrEmpty(val))
                            return;

                        using (MyDayData db = new MyDayData())
                        {
                            var query = from t in db.Tasks
                                        where t.ProjectCode.Equals(txtProject.Text.Trim(), StringComparison.InvariantCultureIgnoreCase)
                                        && t.TaskCode.Equals(val, StringComparison.InvariantCultureIgnoreCase)
                                        select t;

                            var row = query.FirstOrDefault();
                            if (row == null)
                            {
                                newPic = pbNewTask;
                                txtTaskType.Text = String.Empty;
                                txtTaskStatus.Text = String.Empty;
                                txtEstEffort.Text = String.Empty;
                            }
                            else
                            {
                                ctrl.Text = row.TaskCode;
                                txtTaskType.Text = row.TaskTypeCode;
                                txtTaskStatus.Text = row.TaskStatusCode;
                                txtEstEffort.Text = row.EstimatedEffortHours.HasValue ? Convert.ToDouble(row.EstimatedEffortHours).ToString("F2") : "";
                            }
                        }
                    }
                    else if (ctrl == txtTaskType)
                    {
                        if (String.IsNullOrEmpty(val))
                            return;

                        using (MyDayData db = new MyDayData())
                        {
                            var query = from t in db.TaskTypes
                                        where t.TaskTypeCode.Equals(val, StringComparison.InvariantCultureIgnoreCase)
                                        select t;

                            var row = query.FirstOrDefault();
                            if (row == null)
                                newPic = pbNewTaskType;
                            else
                                ctrl.Text = row.TaskTypeCode;
                        }
                    }
                    else if (ctrl == txtTaskType)
                    {
                        if (String.IsNullOrEmpty(val))
                            return;

                        using (MyDayData db = new MyDayData())
                        {
                            var query = from t in db.TaskTypes
                                        where t.TaskTypeCode.Equals(val, StringComparison.InvariantCultureIgnoreCase)
                                        select t;

                            var row = query.FirstOrDefault();
                            if (row == null)
                                newPic = pbNewTaskType;
                            else
                                ctrl.Text = row.TaskTypeCode;
                        }
                    }
                    else if (ctrl == txtTaskStatus)
                    {
                        if (String.IsNullOrEmpty(val))
                            return;

                        using (MyDayData db = new MyDayData())
                        {
                            var query = from t in db.TaskStatuses
                                        where t.TaskStatusCode.Equals(val, StringComparison.InvariantCultureIgnoreCase)
                                        select t;

                            var row = query.FirstOrDefault();
                            if (row == null)
                                newPic = pbNewTaskStatus;
                            else
                                ctrl.Text = row.TaskStatusCode;
                        }
                    }
                    else if (ctrl == txtEstEffort)
                    {
                        if (!String.IsNullOrEmpty(val))
                        {
                            decimal decVal;
                            if (!Decimal.TryParse(val, out decVal) || decVal <= 0)
                            {
                                this.SetStatus("Please enter a valid decimal value");
                                return;
                            }
                            else
                                ctrl.Text = decVal.ToString("F2");
                        }
                    }
                    else if (ctrl == txtAction)
                    {
                        if (String.IsNullOrEmpty(val))
                            return;

                        if (lblActionCode.Text.Equals("(New)"))
                            newPic = pbNewAction;
                    }
                    else if (ctrl == txtActionType)
                    {
                        if (String.IsNullOrEmpty(val))
                            return;

                        using (MyDayData db = new MyDayData())
                        {
                            var query = from t in db.ActionTypes
                                        where t.ActionTypeCode.Equals(val, StringComparison.InvariantCultureIgnoreCase)
                                        select t;

                            var row = query.FirstOrDefault();
                            if (row == null)
                                newPic = pbNewActionType;
                            else
                                ctrl.Text = row.ActionTypeCode;
                        }
                    }

                    this.MoveToNextControl(ctrl, newPic);
                }
                else if (sender is DateTimePicker)
                {
                    DateTimePicker ctrl = (DateTimePicker)sender;

                    if (ctrl == dtpActionTimeTo)
                    {
                        if (dtpActionTimeTo.Value <= dtpActionTimeFrom.Value)
                        {
                            this.SetStatus("The Action End Time must be greater than the Action Start Time");
                            return;
                        }
                    }

                    this.MoveToNextControl(ctrl);
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (sender == txtAction)
                {
                    AutoCompleteBox ctrl = (AutoCompleteBox)sender;

                    SearchList list = new SearchList();

                }
            }
        }

        private void Save()
        {
            try
            {
                using (MyDayData db = new MyDayData())
                {
                    string projectCode = txtProject.Text.Trim();
                    string taskCode = txtTask.Text.Trim();
                    string taskTypeCode = txtTaskType.Text.Trim();
                    string taskStatusCode = txtTaskStatus.Text.Trim();
                    decimal? estEff = null;
                    string estEffStr = txtEstEffort.Text.Trim();
                    if (!String.IsNullOrEmpty(estEffStr))
                        estEff = Convert.ToDecimal(estEffStr);

                    string action = txtAction.Text.Trim();
                    DateTime actionStartTime = dtpActionDate.Value.Date.Add(dtpActionTimeFrom.Value.Subtract(dtpActionTimeFrom.Value.Date));
                    DateTime actionEndTime = dtpActionDate.Value.Date.Add(dtpActionTimeTo.Value.Subtract(dtpActionTimeTo.Value.Date));
                    string actionTypeCode = txtActionType.Text.Trim();

                    if (pbNewProject.Visible)
                    {
                        Project newProject = new Project();
                        newProject.ProjectCode = projectCode;
                        db.AddToProjects(newProject);
                    }

                    if (pbNewTaskType.Visible)
                    {
                        TaskType newTaskType = new TaskType();
                        newTaskType.TaskTypeCode = taskTypeCode;
                        db.AddToTaskTypes(newTaskType);
                    }

                    if (pbNewTaskStatus.Visible)
                    {
                        TaskStatus newTaskStatus = new TaskStatus();
                        newTaskStatus.TaskStatusCode = taskStatusCode;
                        db.AddToTaskStatuses(newTaskStatus);
                    }

                    if (pbNewActionType.Visible)
                    {
                        ActionType newActionType = new ActionType();
                        newActionType.ActionTypeCode = actionTypeCode;
                        db.AddToActionTypes(newActionType);
                    }

                    if (pbNewTask.Visible)
                    {
                        Task newTask = new Task();
                        newTask.ProjectCode = projectCode;
                        newTask.TaskCode = taskCode;
                        newTask.TaskTypeCode = taskTypeCode;
                        newTask.TaskStatusCode = taskStatusCode;
                        newTask.EstimatedEffortHours = estEff;
                        db.AddToTasks(newTask);
                    }
                    else
                    {
                        var query = from t in db.Tasks
                                    where t.ProjectCode.Equals(projectCode, StringComparison.InvariantCultureIgnoreCase)
                                    && t.TaskCode.Equals(taskCode, StringComparison.InvariantCultureIgnoreCase)
                                    select t;

                        Task currentTask = query.First();
                        currentTask.TaskTypeCode = taskTypeCode;
                        currentTask.TaskStatusCode = taskStatusCode;
                        currentTask.EstimatedEffortHours = estEff;
                    }

                    if (lblActionCode.Text == "(New)")
                    {
                        MyDay.Data.Action newAction = new MyDay.Data.Action();
                        newAction.ProjectCode = projectCode;
                        newAction.TaskCode = taskCode;
                        newAction.ActionTypeCode = actionTypeCode;
                        newAction.FromTime = actionStartTime;
                        newAction.ToTime = actionEndTime;
                        newAction.ActionComments = action;
                        db.AddToActions(newAction);
                    }
                    else
                    {
                        long actionCode = Convert.ToInt64(lblActionCode.Text);

                        var query = from t in db.Actions
                                    where t.ActionCode == actionCode
                                    select t;

                        MyDay.Data.Action currentAction = query.First();
                        currentAction.ActionTypeCode = actionTypeCode;
                        currentAction.FromTime = actionStartTime;
                        currentAction.ToTime = actionEndTime;
                        currentAction.ActionComments = action;
                    }

                    db.SaveChanges();
                }

                this.ResetControls(true);
                this.SetStatus("The specified Action was saved successfully");
            }
            catch (Exception ex)
            {
                this.SetStatus(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ResetControls();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void txtFields_SearchComplete(object sender, EventArgs e)
        {
            _keepActive = false;
        }

        private void txtFields_Search(object sender, EventArgs e)
        {
            _keepActive = true;
        }

    }
}
