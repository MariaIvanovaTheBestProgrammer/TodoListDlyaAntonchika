using System;
using System.Collections.Generic;
using System.Text;
using ToDoListForMasha;

namespace ToDoListForMasha.Element
{
    public class RestElement: BasicElement
    {
        public string FilmToWatch { get; set; }
        public RestElement(int id, string name, string description, DateTime creationDate, DateTime deadline, string filmToWatch)
    : base(id, name, description, creationDate, deadline)
        {
            this.FilmToWatch = filmToWatch;
        }

    }

    class Program
    {
        static void Main()
        {
            //var list = new TodoList<object>();


        }
    }
}

