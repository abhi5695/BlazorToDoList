namespace BlazorToDoList.Components.Models
{
    public class ToDoRepository
    {
        private static List<ToDoItem> ToDoList = new List<ToDoItem>
        {
            new ToDoItem{Id=1, Title="New Item", IsCompleted=false}
        };
        public static List<ToDoItem> GetToDos() => ToDoList.OrderByDescending(s=>s.Id).OrderBy(s => s.IsCompleted).ToList();

        public static void AddToDo(ToDoItem toDo)
        {
            int maxId = ToDoList.Max(t => t.Id);
            toDo.Id = maxId + 1;
            ToDoList.Add(toDo);
        }
        public static void UpdateToDo(int id, ToDoItem toDo)
        {
            if (id != toDo.Id) return;

            ToDoItem updatedToDo = ToDoList.FirstOrDefault(t=>t.Id == id);
            if (updatedToDo != null)
            {
                updatedToDo.Title = toDo.Title;
                updatedToDo.IsCompleted = toDo.IsCompleted;
                updatedToDo.CompletedDateTime=DateTime.Now;
            }
        }
    }
}
