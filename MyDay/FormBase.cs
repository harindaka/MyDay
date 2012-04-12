using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyDay
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        private void FormBase_Load(object sender, EventArgs e)
        {

        }

        protected string Status
        {
            get { return lblStatus.Text; }
        }

        protected void SetStatus(string status)
        {
            lblStatus.Text = status;
            ssStatus.Refresh();
        }
        protected void SetStatus(Exception ex)
        {
            this.SetStatus("Exception Occurred: " + ex.Message);
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblStatus.Text))
                MessageBox.Show(lblStatus.Text, "MyDay");
        }
    }
}
