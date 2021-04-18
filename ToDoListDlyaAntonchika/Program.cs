using System;

namespace ToDoListDlyaAntonchika
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                WorkListElement workElement = new WorkListElement(1, "Meeting", "discussion with the customer", new DateTime(2021, 02, 28), new DateTime(2021, 03, 01), new DateTime(2021, 03, 01, 18, 30, 0), "Lasunchik", "buisness");
                //WorkTodoList workTodoList1 = new WorkTodoList(4, "Meeting", "discussion with the customer", new DateTime(2021, 02, 27), new DateTime(2021, 02, 26), new DateTime(2021, 03, 01), "Lasunchik");
                RestListElement restElement = new RestListElement(2, "Film evening", "go to the cinema", new DateTime(2021, 02, 28), new DateTime(2021, 02, 28, 19, 25, 0), "Cherry", FilmGanre.Action);
                SelfDevelopmentListElement selfDevelopmentElement = new SelfDevelopmentListElement(3, "Book time", "Read 50 pages at least", new DateTime(2021, 02, 28), new DateTime(2021, 02, 28), "100 sposobov samorazvitsa");
                TodoList todoList = new TodoList(1, new DateTime(2021, 02, 26), new DateTime(2021, 03, 01), "Routine");
                todoList.AddElementToTodoList(workElement);
                todoList.AddElementToTodoList(restElement);
                todoList.AddElementToTodoList(selfDevelopmentElement);
               // todoList.addElementToTodoList(workTodoList1);
                Console.WriteLine(todoList);
                foreach (BasicListElement b in todoList.data)
                {
                    Console.WriteLine(b);
                }
                Console.WriteLine();
                todoList.DelElementOfTodoList(2);
                foreach (BasicListElement b in todoList.data)
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
