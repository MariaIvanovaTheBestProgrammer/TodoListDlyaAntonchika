using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListDlyaAntonchika
{
    class TodoList 
    {
        public int id { get; set; }
        public List<TodoListBasicElement> data;
        public TodoListBasicElement this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
        public DateTime startDate;
        public DateTime StartDate
        {
            get { return startDate; }
            set
            {
                if (startDate < DateTime.Now)
                {
                    throw new ArgumentException("You can't create plans on this date");
                }
                else
                {
                    startDate = value;
                }
            }
        }
        public DateTime endDate;
        public DateTime EndDate
        {
            get { return endDate; }
            set
            {
                if (endDate < startDate)
                {
                    throw new ArgumentException("You can't end those plans on this date");
                }
                else
                {
                    endDate = value;
                }
            }
        }

        public TodoList(int id, DateTime startDate, DateTime endDate, string description)
        {
            this.id = id;
            data = new List<TodoListBasicElement>();
            this.startDate = startDate;
            this.endDate = endDate;
            this.description = description;
        }

        public String description { get; set; }
        public void addElementToTodoList(TodoListBasicElement element)
        {
            if (element.CreationDate >= startDate && element.Deadline<=endDate)
            {
                data.Add(element);
            }
            else
            {
                throw new ArgumentException("You can't add this plan to this todo list");
            }
        }
        public void delElementOfTodoList(int index)
        {
           data.RemoveAt(index);
        }

        public override string ToString()
        {
            return "Todo List information: "+id+" Start date "+startDate.ToLongDateString() + " End date "+endDate.ToLongDateString() + " "+description;
        }
    }
}
