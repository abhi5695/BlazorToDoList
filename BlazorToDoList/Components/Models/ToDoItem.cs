using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace BlazorToDoList.Components.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CompletedDateTime { get; set; }
    }
}
