using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListDlyaAntonchika
{
    class SelfDevelopmentTodoList : TodoListBasicElement
    {
        private String bookToRead;
        public String BookToRead
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

        public SelfDevelopmentTodoList(int id, string name, string description, DateTime creationDate, DateTime deadline, string bookToRead) 
            : base (id, name, description, creationDate, deadline)
        {
            this.BookToRead = bookToRead;

        }

        public override string ToString()
        {
            return base.ToString()+" Book name: "+ bookToRead;
        }
    }
}
