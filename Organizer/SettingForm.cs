using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Organizer
{
    public partial class SettingForm : Form
    {
        private ColorContainer colorContainer;

        public SettingForm(ColorContainer colorContainer)
        {
            InitializeComponent();
            this.colorContainer = colorContainer;
            pb_clCompleteNotice.BackColor = colorContainer.colorCompleteNotice;
            pb_clNotCompleteNotice.BackColor = colorContainer.colorNotCompleteNotice;
        }

        private void pb_clCompleteNotice_Click(object sender, EventArgs e)
        {
            if (cd_chooseColor.ShowDialog() == DialogResult.OK)
            {
                pb_clCompleteNotice.BackColor = cd_chooseColor.Color;
                colorContainer.colorCompleteNotice = cd_chooseColor.Color;
            }
        }
    }
}
