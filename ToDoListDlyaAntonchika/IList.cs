using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListDlyaAntonchika
{
    interface IList
    {

        void AddElementToTodoList(BasicListElement element);
        void DelElementOfTodoList(int index);
        void DelElementOfTodoListById(int id);
    }
}
