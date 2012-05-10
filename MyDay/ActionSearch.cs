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
        public ActionSearch():base()
        {
            InitializeComponent();
        }

        internal bool ProjectCodeEnabled
        {
            get { return base.txtItem.Enabled; }
            set { base.txtItem.Enabled = false; }
        }

        protected override object Search()
        {
            try
            {
                using (MyDayData db = new MyDayData())
                {
                    var query = from ts in db.Actions
                                where ts.ProjectCode.Equals(this.txtItem.Text.Trim(), StringComparison.InvariantCultureIgnoreCase)
                                orderby ts.ToTime
                                select new
                                {
                                    ActionCode = ts.ActionCode,
                                    Project = ts.ProjectCode,
                                    Task = ts.TaskCode,
                                    From = ts.FromTime,
                                    To = ts.ToTime,
                                    Comments = ts.ActionComments,
                                    ActionType = ts.ActionTypeCode,
                                    Tags = ts.ActionTags.Aggregate(String.Empty, (results, nextString)=> String.Format("{0},{1}", results, nextString))
                                };

                    return query.ToList();
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

                            this.RefreshResults();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                this.SetStatus(ex);
                this.RefreshResults();
            }
            finally
            {
                dgvItems.Focus();
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            this.RefreshResults();
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Delete();
        }
    }
}
