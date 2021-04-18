using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListForMasha.Element
{
    public abstract class BasicElement
    {
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                if (id < 0)
                {
                    throw new ArgumentException("ID must be more than 0");
                }
                else
                {
                    id = value;
                }
            }
        }
        private String name;
        public String Name
        {
            get { return name; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Please enter the name");
                }
                else
                {
                    name = value;
                }
            }
        }
        public String description { get; private set; }

        private DateTime creationDate;
        public DateTime CreationDate
        {
            get { return creationDate; }
            set
            {
                if (value < DateTime.Now)
                {
                    throw new ArgumentException("You can't create plans on this date");
                }
                else
                {
                    creationDate = value;
                }
            }
        }
        private DateTime deadline;
        public DateTime Deadline
        {
            get { return deadline; }
            set
            {
                if (value < creationDate)
                {
                    throw new ArgumentException("Deadline can't be created on this date");
                }
                else
                {
                    deadline = value;
                }
            }
        }

        public BasicElement(int id, string name, string description, DateTime creationDate, DateTime deadline)
        {
            this.Id = id;
            this.Name = name;
            this.description = description;
            this.CreationDate = creationDate;
            this.Deadline = deadline;
        }
        public void changeDeadline(DateTime newDeadline)
        {
            this.deadline = newDeadline;
        }

        public override string ToString()
        {
            return id + ". " + name + ", " + description + ", Creation date: " + creationDate.ToLongDateString() + ", Deadline: " + deadline.ToLongDateString();
        }
    }

}
}
