using System;

namespace ToDoListDlyaAntonchika
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                WorkTodoList workTodoList = new WorkTodoList(1, "Meeting", "discussion with the customer", new DateTime(2021, 02, 27), new DateTime(2021, 03, 01), new DateTime(2021, 03, 01, 18, 30, 0), "Lasunchik");
                //WorkTodoList workTodoList1 = new WorkTodoList(4, "Meeting", "discussion with the customer", new DateTime(2021, 02, 27), new DateTime(2021, 02, 26), new DateTime(2021, 03, 01), "Lasunchik");
                RestTodoList restTodoList = new RestTodoList(2, "Film evening", "go to the cinema", new DateTime(2021, 02, 28), new DateTime(2021, 02, 28, 19, 25, 0), "Cherry");
                SelfDevelopmentTodoList selfDevelopmentTodoList = new SelfDevelopmentTodoList(3, "Book time", "Read 50 pages at least", new DateTime(2021, 02, 27), new DateTime(2021, 02, 28), "100 sposobov samorazvitsa");
                TodoList todoList = new TodoList(1, new DateTime(2021, 02, 26), new DateTime(2021, 03, 01), "Routine");
                todoList.addElementToTodoList(workTodoList);
                todoList.addElementToTodoList(restTodoList);
                todoList.addElementToTodoList(selfDevelopmentTodoList);
               // todoList.addElementToTodoList(workTodoList1);
                Console.WriteLine(todoList);
                foreach (TodoListBasicElement b in todoList.data)
                {
                    Console.WriteLine(b);
                }
                Console.WriteLine();
                todoList.delElementOfTodoList(2);
                foreach (TodoListBasicElement b in todoList.data)
                {
                    Console.WriteLine(b);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
