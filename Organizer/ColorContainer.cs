using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Organizer
{
    public class ColorContainer
    {
        public Color colorCompleteNotice { get; set; }
        public Color colorNotCompleteNotice { get; set; }

        public ColorContainer()
        {
            colorCompleteNotice = Color.FromArgb(145, 129, 81);
            colorNotCompleteNotice = Color.FromArgb(153, 0, 102);
        }
    }
}
