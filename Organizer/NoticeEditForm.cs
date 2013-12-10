using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;

namespace Organizer
{
    class NoticeEditForm : Form
    {
        private RichTextBox rtb_edit;
        private Button bt_cancel;
        private Button bt_ok;

        private CheckBox cb_main;
        public NoticeEditForm(object sender)
            : base()
        {
            cb_main = sender as CheckBox;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Name = "fm_editNotice";
            this.Size = new Size(300,200);
            this.CenterToScreen();
            this.Text = "EditNotice";
            this.BackColor = Color.FromArgb(250,218,221);

            this.rtb_edit = new RichTextBox();
            this.rtb_edit.Name = "rtb_edit";
            this.rtb_edit.Size = new Size(300,100);
            this.rtb_edit.Location = new Point(0, 0);
            this.rtb_edit.Text = cb_main.Text;
            this.Controls.Add(rtb_edit);

            this.bt_ok = new Button();
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new Size(60, 30);
            this.bt_ok.Location = new Point(15, this.rtb_edit.Location.Y + this.rtb_edit.Height + 5);
            this.bt_ok.Text = "OK";
            this.Controls.Add(bt_ok);
            this.bt_ok.Click +=new EventHandler(bt_ok_Click);

            this.bt_cancel = new Button();
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new Size(60, 30);
            this.bt_cancel.Location = new Point(210, this.rtb_edit.Location.Y + this.rtb_edit.Height + 5);
            this.bt_cancel.Text = "Отмена";
            this.Controls.Add(bt_cancel);
            this.bt_cancel.Click +=new EventHandler(bt_cancel_Click);


        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            cb_main.Text = rtb_edit.Text;
            this.Close();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
