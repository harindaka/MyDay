using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms.Design;
using System.Windows.Forms;

namespace MyDay
{
    [Designer(typeof(ControlDesigner))]
    public class InheritableDataGridView : DataGridView
    {
        public InheritableDataGridView()
            : base()
        { }
    }
}
