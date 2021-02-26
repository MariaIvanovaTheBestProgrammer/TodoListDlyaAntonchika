using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListDlyaAntonchika
{
    public class WorkTodoList : TodoListBasicElement
    {
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
        private String meetingPlace;
        public String MeetingPlace
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

        public WorkTodoList(int id, string name, string description, DateTime creationDate, DateTime deadline, DateTime meetingDate, string meetingPlace) 
            : base( id,  name,  description,  creationDate,  deadline)
        {
            this.MeetingDate = meetingDate;
            this.MeetingPlace = meetingPlace;
        }

        public override string ToString()
        {
            return base.ToString() + " Meeting date: "+meetingDate+" Meeting place: "+meetingPlace;
        }
    }
}
