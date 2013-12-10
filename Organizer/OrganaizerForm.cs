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
        private Button bt_deleteSelected;
        private List<CheckBox> listNotice;

        private Color completeColor = Color.FromArgb(145, 129, 81);
        private Color notCompleteColor = Color.FromArgb(153, 0, 102);

        private OrganaizerConteiner organaizerConteiner;

        public OrganaizerForm(DateTime date, OrganaizerConteiner organaizerConteiner)
            : base()
        {
            currDate = date;
            string name = currDate.Day + currDate.ToString("y", CultureInfo.CreateSpecificCulture("en-GB"));
            name = name.Remove(name.IndexOf(' '),1);
            InitializeComponent(name);
            listNotice = new List<CheckBox>();
            this.organaizerConteiner = organaizerConteiner;
            FillNotices();
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

            this.bt_deleteSelected = new Button();
            this.bt_deleteSelected.Name = "bt_deleteSelected";
            this.bt_deleteSelected.Size = new Size(130, 25);
            this.bt_deleteSelected.Location = new Point(this.bt_addNotice.Location.X + this.bt_addNotice.Width + 20, this.bt_addNotice.Location.Y);
            this.bt_deleteSelected.Text = "Удалить выделенные";
            this.Controls.Add(bt_deleteSelected);
            this.bt_deleteSelected.Click += new EventHandler(bt_deleteSelected_Click);

        }

        private void AddNotice(string text,bool isComplete)
        {
            CheckBox cb_notice = new CheckBox();
            cb_notice.Name = "cb_notice1";
            cb_notice.Size = new Size(300,40);
            cb_notice.ForeColor = isComplete ? completeColor : notCompleteColor;

            cb_notice.Text = text;

            if(listNotice.Count == 0)
                cb_notice.Location = new Point(30,this.bt_addNotice.Location.Y + this.bt_addNotice.Height + 20);
            else
                cb_notice.Location = new Point(30, listNotice[listNotice.Count - 1].Location.Y + cb_notice.Height);

            if (text == "")
            {
                NoticeEditForm formEdit = new NoticeEditForm(cb_notice);
                formEdit.ShowDialog();
            }

            this.Controls.Add(cb_notice);
            listNotice.Add(cb_notice);
            if(text == "")
                organaizerConteiner.listNotices.Add(new OrganaizerConteiner.SingleNotice(currDate,DateTime.Now,cb_notice.Text,isComplete));

            ContextMenu cm_ComboBox = new ContextMenu();
            MenuItem mi_edit = new MenuItem();
            MenuItem mi_delete = new MenuItem();
            MenuItem mi_complete = new MenuItem();
            MenuItem mi_notComplete = new MenuItem();
            cm_ComboBox.MenuItems.AddRange(new MenuItem[] {mi_complete,mi_notComplete,mi_edit,mi_delete});

            mi_complete.Index = 0;
            mi_complete.Text = "Выполнено";
            mi_complete.Click +=new EventHandler(mi_complete_Click);

            mi_notComplete.Index = 1;
            mi_notComplete.Text = "Не выполнено";

            mi_edit.Index = 2;
            mi_edit.Text = "Изменить";
            mi_edit.Click += new EventHandler(mi_edit_Click);
  
            mi_delete.Index = 3;
            mi_delete.Text = "Удалить";
            cb_notice.ContextMenu = cm_ComboBox;
            mi_delete.Click += new EventHandler(mi_delete_Click);
        }

        private void ClearListNotices()
        {
            while (listNotice.Count != 0)
            {
                this.Controls.Remove(listNotice[0]);
                this.listNotice.RemoveAt(0);
            }            
        }

        private void FillNotices()
        {
            ClearListNotices();
            for (int i = 0; i < organaizerConteiner.listNotices.Count; ++i)
            {
                if (organaizerConteiner.listNotices[i].noticeDate.Date == currDate.Date)
                    AddNotice(organaizerConteiner.listNotices[i].text,organaizerConteiner.listNotices[i].isComplete);
            }

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        private void bt_decreaseDate_Click(object sender, EventArgs e)
        {
            currDate = currDate.AddDays(-1);
            this.lb_date.Text = currDate.ToString("D");
            FillNotices();
        }

        private void bt_increaseDate_Click(object sender, EventArgs e)
        {
            currDate = currDate.AddDays(1);
            this.lb_date.Text = currDate.ToString("D");
            FillNotices();
        }

        private void bt_addNotice_Click(object sender, EventArgs e)
        {
            AddNotice("",false);
        }

        private void bt_deleteSelected_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listNotice.Count; ++i)
            {
                if (listNotice[i].Checked)
                {
                    organaizerConteiner.DeleteNotice(currDate,listNotice[i].Text);
                    this.Controls.Remove(listNotice[i]);
                    listNotice.RemoveAt(i);
                    --i;
                }
            }
            FillNotices();
        }

        private void mi_edit_Click(object sender, EventArgs e)
        {
            ContextMenu cm_parent = (sender as MenuItem).GetContextMenu();
            NoticeEditForm formEdit = new NoticeEditForm(cm_parent.SourceControl);
            formEdit.ShowDialog();
        }

        private void mi_delete_Click(object sender, EventArgs e)
        {
            ContextMenu cm_parent = (sender as MenuItem).GetContextMenu();
            CheckBox cmb = cm_parent.SourceControl as CheckBox;
            organaizerConteiner.DeleteNotice(currDate,cmb.Text);
            this.Controls.Remove(listNotice[listNotice.IndexOf(cmb)]);
            listNotice.RemoveAt(listNotice.IndexOf(cmb));            
            FillNotices();
        }

        private void mi_complete_Click(object sender, EventArgs e)
        {
            ContextMenu cm_parent = (sender as MenuItem).GetContextMenu();
            CheckBox cb = cm_parent.SourceControl as CheckBox;
            int numberNotice = organaizerConteiner.GetIndexNotice(currDate, cb.Text);
            organaizerConteiner.listNotices.Add(new OrganaizerConteiner.SingleNotice(organaizerConteiner.listNotices[numberNotice].noticeDate, organaizerConteiner.listNotices[numberNotice].addingDate, organaizerConteiner.listNotices[numberNotice].text,true));
            organaizerConteiner.listNotices.RemoveAt(numberNotice);
            FillNotices();
        }
    }
}
