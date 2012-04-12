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
    public partial class ActionTypes : FormBase
    {
        public ActionTypes()
        {
            InitializeComponent();
        }

        private void PopulateList()
        {
            try{
            using (MyDayData db = new MyDayData())
            {
                var query = from ts in db.ActionTypes
                            select new { ActionType = ts.ActionTypeCode };

                dgvItems.DataSource = query;
            }
            }
            catch (Exception ex)
            {
                this.SetStatus(ex);
            }
            finally
            {
                txtItem.Focus();
            }
        }

        private void Add()
        {
            try
            {
                string item = txtItem.Text.Trim();
                if (!String.IsNullOrEmpty(item))
                {
                    using (MyDayData db = new MyDayData())
                    {

                        var query = from ts in db.ActionTypes
                                    where ts.ActionTypeCode == item
                                    select new { ActionType = ts.ActionTypeCode };

                        if (query.FirstOrDefault() == null)
                        {
                            ActionType newItem = new ActionType { ActionTypeCode = item };
                            db.AddToActionTypes(newItem);
                            db.SaveChanges();
                            this.SetStatus("Item was added successfully");

                            this.PopulateList();

                            txtItem.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                this.SetStatus(ex);
                this.PopulateList();
            }
            finally
            {
                txtItem.Focus();
            }
        }

        private void Delete()
        {
            try
            {
                if (dgvItems.SelectedRows.Count > 0)
                {
                    List<string> selections = new List<string>();
                    foreach (DataGridViewRow row in dgvItems.SelectedRows)
                        selections.Add(Convert.ToString(row.Cells[0].Value));

                    using (MyDayData db = new MyDayData())
                    {
                        var query = from ts in db.ActionTypes
                                    where selections.Contains(ts.ActionTypeCode)
                                    select ts;

                        if (query.FirstOrDefault() != null)
                        {
                            foreach (var row in query)
                                db.ActionTypes.DeleteObject(row);

                            db.SaveChanges();
                            this.SetStatus("Selected items were deleted successfully");

                            this.PopulateList();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                this.SetStatus(ex);
                this.PopulateList();
            }
            finally
            {
                txtItem.Focus();
            }
        }

        private void TaskStatuses_Load(object sender, EventArgs e)
        {
            this.PopulateList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Add();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Delete();
        }
    }
}
