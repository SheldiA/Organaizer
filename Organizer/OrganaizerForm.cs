using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;

namespace Organizer
{
    class OrganaizerForm : Form
    {
        private DateTime currDate;
        private Label lb_date;
        private Button bt_addNotice;
        private Button bt_decreaseDate;
        private Button bt_increaseDate;
        private List<CheckBox> listNotice;

        public OrganaizerForm(DateTime date)
            : base()
        {
            currDate = date;
            string name = currDate.Day + currDate.ToString("y", CultureInfo.CreateSpecificCulture("en-GB"));
            name = name.Remove(name.IndexOf(' '),1);
            InitializeComponent(name);
            listNotice = new List<CheckBox>();
        }

        private void InitializeComponent(string name)
        {
            this.Name = "fm_" + name;
            this.Text = "Список дел на день";
            this.Height = 500;
            this.Width = 400;
            this.CenterToScreen();
            this.BackColor = Color.FromArgb(255,209,220);
            this.AutoScroll = true;

            this.lb_date = new Label();
            this.lb_date.Name = "lb_date";
            this.lb_date.Text = currDate.ToString("D");
            this.lb_date.Location = new Point(150,10);
            //this.lb_date.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date.ForeColor = Color.FromArgb(220, 20, 60);
            this.Controls.Add(lb_date);

            this.bt_decreaseDate = new Button();
            this.bt_decreaseDate.Name = "bt_decreaseDate";
            this.bt_decreaseDate.Size = new Size(30,30);
            this.bt_decreaseDate.Location = new Point(this.lb_date.Location.X - 70,this.lb_date.Location.Y);            
            this.bt_decreaseDate.Text = "<";
            this.Controls.Add(bt_decreaseDate);
            this.bt_decreaseDate.Click += new EventHandler(this.bt_decreaseDate_Click);

            this.bt_increaseDate = new Button();
            this.bt_increaseDate.Name = "bt_increaseDate";
            this.bt_increaseDate.Size = new Size(30, 30);
            this.bt_increaseDate.Location = new Point(this.lb_date.Location.X + this.lb_date.Width + 40, this.lb_date.Location.Y);
            this.bt_increaseDate.Text = ">";
            this.Controls.Add(bt_increaseDate);
            this.bt_increaseDate.Click += new EventHandler(bt_increaseDate_Click);

            this.bt_addNotice = new Button();
            this.bt_addNotice.Name = "bt_addNotice";
            this.bt_addNotice.Size = new Size(75,25);
            this.bt_addNotice.Location = new Point(30,this.bt_decreaseDate.Location.Y + this.bt_decreaseDate.Height + 20);
            this.bt_addNotice.Text = "+Добавить";
            this.Controls.Add(bt_addNotice);
            this.bt_addNotice.Click +=new EventHandler(bt_addNotice_Click);

        }

        private void AddNotice()
        {
            CheckBox cb_notice = new CheckBox();
            cb_notice.Name = "cb_notice1";
            cb_notice.Size = new Size(300,40);
            cb_notice.Text = "dfgdfgdfg";
            if(listNotice.Count == 0)
                cb_notice.Location = new Point(30,this.bt_addNotice.Location.Y + this.bt_addNotice.Height + 20);
            else
                cb_notice.Location = new Point(30, listNotice[listNotice.Count - 1].Location.Y + cb_notice.Height);
            this.Controls.Add(cb_notice);
            listNotice.Add(cb_notice);

            NoticeEditForm formEdit = new NoticeEditForm(cb_notice);
            formEdit.ShowDialog();

            ContextMenu cm_ComboBox = new ContextMenu();
            MenuItem mi_edit = new MenuItem();
            MenuItem mi_delete = new MenuItem();
            cm_ComboBox.MenuItems.AddRange(new MenuItem[] {mi_edit,mi_delete});
            mi_edit.Index = 0;
            mi_edit.Text = "Изменить";
            mi_edit.Click += new EventHandler(mi_edit_Click);
  
            mi_delete.Index = 1;
            mi_delete.Text = "Удалить";
            cb_notice.ContextMenu = cm_ComboBox;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        private void bt_decreaseDate_Click(object sender, EventArgs e)
        {
            currDate = currDate.AddDays(-1);
            this.lb_date.Text = currDate.ToString("D");
        }

        private void bt_increaseDate_Click(object sender, EventArgs e)
        {
            currDate = currDate.AddDays(1);
            this.lb_date.Text = currDate.ToString("D");
        }

        private void bt_addNotice_Click(object sender, EventArgs e)
        {
            AddNotice();
        }

        private void mi_edit_Click(object sender, EventArgs e)
        {
            ContextMenu cm_parent = (sender as MenuItem).GetContextMenu();
            NoticeEditForm formEdit = new NoticeEditForm(cm_parent.SourceControl);
            formEdit.ShowDialog();
        }
    }
}
