using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyDay.Data;
using System.Collections;

namespace MyDay
{
    public partial class ActionSearch : SearchList
    {
        public ActionSearch()
            : base()
        {
            InitializeComponent();
        }

        internal string ProjectCode { get; set; }

        internal string TaskCode { get; set; }
        
        private Control GetNextControl(Control ctrl)
        {
            if (ctrl == txtActionType)
                return dtpFrom;
            else if (ctrl == dtpFrom)
                return dtpTo;
            else if (ctrl == dtpTo)
                return txtQuickSearchTerm;
            else if (ctrl == txtQuickSearchTerm)
                return btnSearch;
            else if (ctrl == btnSearch)
                return btnOK;
            
            return null;
        }

        private void MoveToNextControl(Control currentControl)
        {
            Control nextCtrl = this.GetNextControl(currentControl);
            nextCtrl.Focus();
            if (nextCtrl is TextBox)
                ((TextBox)nextCtrl).SelectAll();

            this.SetStatus(String.Empty);
        }

        private void Initialize()
        {
            btnOK.Enabled = false;
        }

        protected override object OnSearch()
        {
            try
            {
                using (MyDayData db = new MyDayData())
                {
                    bool ignoreContainsPhrase = String.IsNullOrEmpty(txtQuickSearchTerm.Text.Trim());

                    var query = from a in db.Actions
                                         from t in db.ActionTags.Where(tag => tag.ActionCode == a.ActionCode).DefaultIfEmpty()
                                         where a.ProjectCode == this.ProjectCode
                                         && a.TaskCode == this.TaskCode
                                         && (ignoreContainsPhrase || a.ActionComments.Contains(this.txtQuickSearchTerm.Text.Trim()))
                                         && ((a.FromTime <= dtpFrom.Value && a.FromTime >= dtpTo.Value) || (a.ToTime >= dtpFrom.Value && a.ToTime <= dtpTo.Value))
                                         orderby a.FromTime, t.TagCode
                                         select new
                                         {
                                             ActionCode = a.ActionCode,
                                             FromTime = a.FromTime,
                                             ToTime = a.ToTime,
                                             ActionComments = a.ActionComments,
                                             ActionTypeCode = a.ActionTypeCode,
                                             TagCode = t.TagCode
                                         };

                    var groupedActions = from a in query.ToList()
                                         group a by a.ActionCode into g
                                         select new
                                         {
                                             ActionCode = g.First().ActionCode,
                                             From = g.First().FromTime,
                                             To = g.First().ToTime,
                                             Comments = g.First().ActionComments,
                                             ActionType = g.First().ActionTypeCode,
                                             Tags = String.Join(",", g.Select(row => row.TagCode))
                                         };
                                        
                    return groupedActions.ToList();                   
                }
            }
            catch (Exception ex)
            {
                this.SetStatus(ex);
                return null;
            }
        }

        private void Delete()
        {
            try
            {
                if (dgvItems.SelectedRows.Count > 0)
                {
                    List<Int64> selections = new List<Int64>();
                    foreach (DataGridViewRow row in dgvItems.SelectedRows)
                        selections.Add(Convert.ToInt64(row.Cells[0].Value));

                    using (MyDayData db = new MyDayData())
                    {
                        var query = from ts in db.Actions
                                    where selections.Contains(ts.ActionCode)
                                    select ts;

                        if (query.FirstOrDefault() != null)
                        {
                            foreach (var row in query)
                                db.Actions.DeleteObject(row);

                            db.SaveChanges();
                            this.SetStatus("Selected items were deleted successfully");

                            this.Search();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                this.SetStatus(ex);
                this.Search();
            }
            finally
            {
                dgvItems.Focus();
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Delete();
        }

        private void Fields_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Control ctrl = (Control)sender;
                this.MoveToNextControl(ctrl);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Search();
        }
    }
}
