using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Organizer
{
    public partial class FormMain : Form
    {
        private DateTime currDate;
        private Calendar calendar;
        private OrganaizerConteiner organaizerConteiner;
        private ColorContainer colorContainer;

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
            organaizerConteiner = new OrganaizerConteiner();
            OpenFile();
            colorContainer = new ColorContainer();
        }

        private void SaveInFile()
        {
            FileStream fs = new FileStream("dataFile.dat",FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs,organaizerConteiner.listNotices);
            fs.Close();
        }

        private void OpenFile()
        {
            if (organaizerConteiner.listNotices.Count != 0)
                organaizerConteiner.listNotices.Clear();
            FileStream fs = new FileStream("dataFile.dat",FileMode.Open);
            if (fs != null)
            {
                BinaryFormatter bf = new BinaryFormatter();
                organaizerConteiner.listNotices = (List<OrganaizerConteiner.SingleNotice>)bf.Deserialize(fs);
                fs.Close();
            }
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
            OrganaizerForm formO = new OrganaizerForm(currDate,organaizerConteiner,colorContainer);
            formO.Show();
        }

        private void dgv_calendar_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DateTime date = new DateTime(currDate.Year,currDate.Month,(int)dgv_calendar.SelectedCells[0].Value);
            OrganaizerForm formO = new OrganaizerForm(date,organaizerConteiner,colorContainer);
            formO.Show();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveInFile();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                this.Close();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm(colorContainer);
            settingForm.ShowDialog();
        }


        
    }
}
