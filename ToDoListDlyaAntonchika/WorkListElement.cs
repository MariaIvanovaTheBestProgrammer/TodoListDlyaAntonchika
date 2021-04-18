using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListDlyaAntonchika
{
    class WorkListElement : BasicListElement
    {
        private string meetingType;
        public override string GetMainActivity
        {
            get { return meetingType; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Please enter the meeting type");
                }
                else
                {
                    meetingType = value;
                }
            }
        }
        private DateTime meetingDate;
        public DateTime MeetingDate
        {
            get { return meetingDate; }
            set
            {
                if (value < DateTime.Now)
                {
                    throw new ArgumentException("You can't create plans on this date");
                }
                else
                {
                    meetingDate = value;
                }
            }
        }
        private string meetingPlace;
        public string MeetingPlace
        {
            get { return meetingPlace; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Please enter the meeting place name");
                }
                else
                {
                    meetingPlace = value;
                }
            }
        }

        public WorkListElement(int id, string name, string description, DateTime creationDate, DateTime deadline, DateTime meetingDate, string meetingPlace, string meetingType)
            : base(id, name, description, creationDate, deadline)
        {
            this.MeetingDate = meetingDate;
            this.MeetingPlace = meetingPlace;
            this.GetMainActivity = meetingType;
        }

        public override string ToString()
        {
            return base.ToString() + " Meeting date: " + meetingDate + " Meeting place: " + meetingPlace + " Meeting type: " + meetingType;
        }
    }
}
