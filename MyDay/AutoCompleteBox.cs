using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyDay
{
    public class AutoCompleteBox : TextBox
    {
        public event EventHandler Search;
        public event EventHandler SearchComplete;

        List<string> _autoCompleteList;

        public AutoCompleteBox()
            : base()
        {
            this.SearchListCaption = "Search";
        }

        protected virtual void OnSearch(EventArgs e)
        {
            EventHandler evnt = this.Search;
            if (evnt != null)
                this.Search(this, e);
        }

        protected virtual void OnSearchComplete(EventArgs e)
        {
            EventHandler evnt = this.SearchComplete;
            if (evnt != null)
                this.SearchComplete(this, e);
        }

        public string SearchListCaption { get; set; }

        public List<string> AutoCompleteList
        {
            get { return _autoCompleteList; }
            set {
                if (value == null)
                {
                    this.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
                    this.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
                    this.AutoCompleteCustomSource = null;
                }
                else
                {
                    this.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
                    this.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
                    AutoCompleteStringCollection items = new AutoCompleteStringCollection();
                    items.AddRange(value.ToArray());
                    this.AutoCompleteCustomSource = items;
                }
                
                _autoCompleteList = value;
            }
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
                        
            if (e.KeyCode == Keys.Up)
            {
                this.OnSearch(new EventArgs());

                SearchList list = new SearchList();
                list.Source = _autoCompleteList;
                list.SearchTerm = this.Text;
                list.Text = this.SearchListCaption;
                                
                list.StartPosition = FormStartPosition.CenterParent;
                list.ShowDialog(this);

                if (!String.IsNullOrEmpty(list.Result))
                {
                    this.Text = list.Result;
                    this.SelectAll();
                }

                this.OnSearchComplete(new EventArgs());
            }
        }
    }
}
