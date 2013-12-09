using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Organizer
{
    class OrganaizerConteiner
    {
        public struct SingleNotice
        {
            DateTime noticeDate;
            DateTime addingDate;
            string text;
            public SingleNotice(DateTime noticeDate, DateTime addingDate, string text)
            {
                this.noticeDate = noticeDate;
                this.addingDate = addingDate;
                this.text = text;
            }
        };

        public List<SingleNotice> listNotices;

        public OrganaizerConteiner()
        {
            listNotices = new List<SingleNotice>();
        }
    }
}
