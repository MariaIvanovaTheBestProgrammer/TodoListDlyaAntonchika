using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoListDlyaAntonchika
{
    class TodoList : IList
    {
        public int id { get; set; }
        private List<BasicListElement> data;
        public BasicListElement this[int index]
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
            data = new List<BasicListElement>();
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.description = description;
        }
        public TodoList(int id,List<BasicListElement> list, DateTime startDate, DateTime endDate, string description)
        {
            this.id = id;
            data = list;
            this.startDate = startDate;
            this.endDate = endDate;
            this.description = description;
        }
        public string description { get; set; }
        public void AddElementToTodoList(BasicListElement element)
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
        public void DelElementOfTodoList(int index)
        {
           data.RemoveAt(index);
        }
        public void DelElementOfTodoListById(int id)
        {
            var itemToRemove = data.SingleOrDefault(r => r.Id == id);
            data.Remove(itemToRemove);
        }
        public override string ToString()
        {
            return "Todo List information: "+id+" Start date "+startDate.ToLongDateString() + " End date "+endDate.ToLongDateString() + " "+description;
        }

    }
}
