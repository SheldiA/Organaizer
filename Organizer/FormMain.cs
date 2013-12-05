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
        private readonly string[] monthArray = {"Январь","Февраль","Март","Апрель","Май","Июнь","Июль","Август","Сентябрь","Октябрь","Ноябрь","Декабрь"};
        private DateTime currDate;
        private Calendar calendar;
        public FormMain()
        {
            InitializeComponent();
            for (int i = 0; i < 6; ++i )
                dgv_calendar.Rows.Add();
            currDate = DateTime.Now;
            lb_month.Text = monthArray[currDate.Month - 1] + " " + currDate.Year;
            calendar = new Calendar();
            calendar.FillMonth(currDate, dgv_calendar);
            this.BackColor = Color.FromArgb(232,213,238);
        }

        private void pb_increaseMonth_Click(object sender, EventArgs e)
        {
            currDate = currDate.AddMonths(1);
            lb_month.Text = monthArray[currDate.Month - 1] + " " + currDate.Year;
            calendar.FillMonth(currDate, dgv_calendar);
        }

        private void pb_decreaseMonth_Click(object sender, EventArgs e)
        {
            currDate = currDate.AddMonths(-1);
            lb_month.Text = monthArray[currDate.Month - 1] + " " + currDate.Year;
            calendar.FillMonth(currDate, dgv_calendar);
        }

        
    }
}
