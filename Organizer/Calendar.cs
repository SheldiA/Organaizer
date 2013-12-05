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
        public void FillMonth(DateTime date, object gridView)
        {
            DateTime currDate = new DateTime(date.Year,date.Month,1);
            Color clBeyondMonth = Color.FromArgb(208,198,223);
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
        }
    }
}
