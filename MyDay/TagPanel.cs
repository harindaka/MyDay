using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace MyDay
{
    public class TagPanel : FlowLayoutPanel
    {
        public TagPanel()
            : base()
        {
            this.Tags = new Dictionary<string, string>();

            this.AutoScroll = true;
        }

        protected Dictionary<string, string> Tags { get; set; }

        public void AddTag(string key, string value)
        {
            this.Tags.Add(key, value);

            Button btn = new Button();
            btn.FlatStyle = FlatStyle.Popup;
            btn.AutoSize = true;
            btn.Text = value;
            btn.Tag = key;
            
            this.Controls.Add(btn);

            btn.Click += new EventHandler(btn_Click);
        }

        public bool ContainsTag(string key)
        {
            return !this.Tags.FirstOrDefault(x => x.Key.Equals(key, StringComparison.InvariantCultureIgnoreCase)).Equals(default(KeyValuePair<string, string>));
        }

        public void ClearTags()
        {
            this.Tags.Clear();
            this.Controls.Clear();
        }

        public Dictionary<string, string> GetTags()
        {
            return this.Tags.ToDictionary(x => x.Key, x => x.Value);
        }

        void btn_Click(object sender, EventArgs e)
        {
            ContextMenu menu = new ContextMenu();

            MenuItem menuItem = new MenuItem();
            menuItem.Tag = sender;
            menuItem.Text = "Remove";
            menuItem.Click += new EventHandler(menuItem_Click);

            menu.MenuItems.Add(menuItem);

            Button btn = (Button)sender;
            menu.Show(btn, new Point(0, btn.Height));
        }

        void menuItem_Click(object sender, EventArgs e)
        {
            Button btn = (Button)((MenuItem)sender).Tag;
            this.Tags.Remove(Convert.ToString(btn.Tag));
            this.Controls.Remove(btn);
        }
    }
}
