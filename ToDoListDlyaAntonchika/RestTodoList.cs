using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListDlyaAntonchika
{
    class RestTodoList : TodoListBasicElement
    {
        private String filmToWatch;
        public String FilmToWatch
        {
            get { return filmToWatch; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Please enter the film name");
                }
                else
                {
                    filmToWatch = value;
                }
            }

        }
        public RestTodoList(int id, string name, string description, DateTime creationDate, DateTime deadline, string filmToWatch)
            : base(id, name, description, creationDate, deadline)
        {
            this.FilmToWatch = filmToWatch;
        }

        public override string ToString()
        {
            return base.ToString() + " Film name: "+filmToWatch;
        }
    }
}
