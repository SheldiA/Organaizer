using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Organizer
{
    class Calendar
    {
        private DateTime todayData;
        public Calendar(DateTime today)
        {
            todayData = today;
        }

        public void FillMonth(DateTime date, object gridView)
        {
            DateTime currDate = new DateTime(date.Year,date.Month,1);
            Color clBeyondMonth = Color.FromArgb(216,191,216);
            Color clInMonth = Color.Ivory;
            Color currColor;
            
            int dayBeginMonth = (int)currDate.DayOfWeek - 1;
            if (dayBeginMonth == -1)
                dayBeginMonth = 6;
            int day = 1;
            DateTime previousMonthDate = currDate.AddMonths(-1);
            int dayPreviousMonth = DateTime.DaysInMonth(previousMonthDate.Year,previousMonthDate.Month);
            for (int i = dayBeginMonth - 1; i >= 0; --i, --dayPreviousMonth)
            {
                (gridView as DataGridView)[i, 0].Value = dayPreviousMonth;
                (gridView as DataGridView)[i, 0].Style.BackColor = clBeyondMonth;
            }

            currColor = clInMonth;
            for (int i = 0; i < 6; ++i)
            {
                int j = (i == 0) ? dayBeginMonth : 0;
                for (; j < 7; ++j)
                {
                    if (day > DateTime.DaysInMonth(currDate.Year, currDate.Month))
                    {
                        day = 1;
                        currColor = clBeyondMonth;
                    }
                    (gridView as DataGridView)[j, i].Value = day;
                    (gridView as DataGridView)[j, i].Style.BackColor = currColor;
                    ++day;
                }
            }
            if ((date.Month == todayData.Month) && (date.Year == todayData.Year))
                SeparateOutToday(todayData, gridView);
        }

        public void SeparateOutToday(DateTime now, object sender)
        {
            DataGridView dgv = sender as DataGridView;
            for (int i = 0; i < 6; ++i)
                for (int j = 0; j < 7; ++j)
                    if ((int)dgv[j, i].Value == now.Day)
                    {
                        if((int)dgv[j,i].Value < 6)
                        {
                            if (i < 3)
                                dgv[j, i].Style.BackColor = Color.FromArgb(255,105,180);                            
                        }
                        else
                            if ((int)dgv[j, i].Value > 25)
                            {
                                if(i > 3)
                                    dgv[j, i].Style.BackColor = Color.FromArgb(255, 105, 180);
                            }
                            else
                                dgv[j, i].Style.BackColor = Color.FromArgb(255, 105, 180);
                    }
        }
    }
}
