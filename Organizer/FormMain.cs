using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Organizer
{
    public partial class FormMain : Form
    {
        private DateTime currDate;
        private Calendar calendar;
        public FormMain()
        {
            InitializeComponent();
            for (int i = 0; i < 6; ++i )
                dgv_calendar.Rows.Add();
            currDate = DateTime.Now;
            lb_month.Text = currDate.ToString("y");
            calendar = new Calendar(currDate);
            calendar.FillMonth(currDate, dgv_calendar);
            this.BackColor = Color.FromArgb(232,213,238);
        }

        private void pb_increaseMonth_Click(object sender, EventArgs e)
        {
            currDate = currDate.AddMonths(1);
            lb_month.Text = currDate.ToString("y");
            calendar.FillMonth(currDate, dgv_calendar);
        }

        private void pb_decreaseMonth_Click(object sender, EventArgs e)
        {
            currDate = currDate.AddMonths(-1);
            lb_month.Text = currDate.ToString("y");
            calendar.FillMonth(currDate, dgv_calendar);
        }

        private void органайзерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrganaizerForm formO = new OrganaizerForm(currDate);
            formO.Show();
        }

        private void dgv_calendar_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DateTime date = new DateTime(currDate.Year,currDate.Month,(int)dgv_calendar.SelectedCells[0].Value);
            OrganaizerForm formO = new OrganaizerForm(date);
            formO.Show();
        }


        
    }
}
