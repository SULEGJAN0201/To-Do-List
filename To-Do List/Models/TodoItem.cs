using System.ComponentModel.DataAnnotations;

namespace To_Do_List.Models
{
    public class TodoItem
    {
        public int Id { get; set; }

        
        public required string  Title { get; set; }

        public string? Description { get; set; }

        public bool IsComplete { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? CompletedAt { get; set; }
    }
}
