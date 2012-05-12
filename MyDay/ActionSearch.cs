using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyDay.Data;

namespace MyDay
{
    public partial class ActionSearch : SearchList
    {
        public ActionSearch()
            : base()
        {
            InitializeComponent();
        }

        internal bool ProjectCodeEnabled
        {
            get { return base.txtQuickSearchTerm.Enabled; }
            set { base.txtQuickSearchTerm.Enabled = false; }
        }

        protected override object OnSearch()
        {
            try
            {
                using (MyDayData db = new MyDayData())
                {
                    var query = from a in db.Actions
                                         from t in db.ActionTags.Where(tag => tag.ActionCode == a.ActionCode).DefaultIfEmpty()
                                         where a.ProjectCode.Equals(this.txtQuickSearchTerm.Text.Trim(), StringComparison.InvariantCultureIgnoreCase)
                                         orderby a.ToTime, t.TagCode
                                         select new
                                         {
                                             ActionCode = a.ActionCode,
                                             ProjectCode = a.ProjectCode,
                                             TaskCode = a.TaskCode,
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
                                             Project = g.First().ProjectCode,
                                             Task = g.First().TaskCode,
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
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Delete();
        }
    }
}
