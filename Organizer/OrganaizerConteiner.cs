using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Organizer
{
    class OrganaizerConteiner
    {
        [Serializable]
        public struct SingleNotice
        {
            public DateTime noticeDate;
            public DateTime addingDate;
            public string text;
            public bool isComplete;
            public SingleNotice(DateTime noticeDate, DateTime addingDate, string text,bool isComplete)
            {
                this.noticeDate = noticeDate;
                this.addingDate = addingDate;
                this.text = text;
                this.isComplete = isComplete;
            }
        };

        public List<SingleNotice> listNotices;

        public OrganaizerConteiner()
        {
            listNotices = new List<SingleNotice>();
        }

        public void DeleteNotice(DateTime date,string textNotice)
        {
            listNotices.RemoveAt(GetIndexNotice(date,textNotice));
        }

        public int GetIndexNotice(DateTime date, string textNotice)
        {
            int result = 0;
            for (int i = 0; i < listNotices.Count; ++i)
            {
                if (listNotices[i].noticeDate.Date == date.Date && listNotices[i].text == textNotice)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }
    }
}
