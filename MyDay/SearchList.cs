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
    public partial class SearchList : FormBase
    {
        public SearchList()
        {
            InitializeComponent();
        }

        public List<string> QuickSearchSource
        {
            get;
            set;
        }

        public string QuickSearchTerm
        {
            get;
            set;
        }

        public string Result
        {
            get;
            set;
        }

        protected virtual object Search()
        {
            string searchTerm = txtItem.Text.ToLower();

            var query = from s in this.QuickSearchSource
                        where s.ToLower().Contains(searchTerm)
                        select new { Item = s };

            return query.ToList();
        }

        protected virtual void RefreshResults()
        {
            dgvItems.DataSource = this.Search();
        }

        private void ReturnSelection()
        {
            if (dgvItems.SelectedRows.Count > 0)
                this.Result = Convert.ToString(dgvItems.SelectedRows[0].Cells[0].Value);
            else
                this.Result = String.Empty;

            this.Close();
        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {
            this.RefreshResults();
        }

        private void SearchList_Load(object sender, EventArgs e)
        {
            txtItem.Text = this.QuickSearchTerm;
            txtItem.SelectAll();
            this.RefreshResults();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.ReturnSelection();
        }

        private void dgvItems_DoubleClick(object sender, EventArgs e)
        {
            this.ReturnSelection();
        }

        private void txtItem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (dgvItems.RowCount > 0 && dgvItems.CurrentRow.Index < dgvItems.Rows.Count - 1)
                {
                    int nextRowIndex = dgvItems.CurrentRow.Index + 1;
                    dgvItems.Rows[nextRowIndex].Selected = true;
                    dgvItems.CurrentCell = dgvItems.Rows[nextRowIndex].Cells[0];
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (dgvItems.RowCount > 0 && dgvItems.CurrentRow.Index > 0)
                {
                    int nextRowIndex = dgvItems.CurrentRow.Index - 1;
                    dgvItems.Rows[nextRowIndex].Selected = true;
                    dgvItems.CurrentCell = dgvItems.Rows[nextRowIndex].Cells[0];
                }
            }
        }
    }
}
