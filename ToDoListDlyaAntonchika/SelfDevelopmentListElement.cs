using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListDlyaAntonchika
{
    class SelfDevelopmentListElement : BasicListElement
    {
        private string bookToRead;
        public override string GetMainActivity
        {
            get { return bookToRead; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Please enter the book name");
                }
                else
                {
                    bookToRead = value;
                }
            }

        }

        public SelfDevelopmentListElement(int id, string name, string description, DateTime creationDate, DateTime deadline, string bookToRead)
            : base(id, name, description, creationDate, deadline)
        {
            this.GetMainActivity = bookToRead;

        }

        public override string ToString()
        {
            return base.ToString() + " Book name: " + bookToRead;
        }

    }
}
