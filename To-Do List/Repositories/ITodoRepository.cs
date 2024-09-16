using To_Do_List.Models;

namespace To_Do_List.Repositories
{
    public interface ITodoRepository
    {
       
            Task<IEnumerable<TodoItem>> GetAllAsync();
            Task<TodoItem?> GetByIdAsync(int id);
            Task<TodoItem> CreateAsync(TodoItem todoItem);
            Task UpdateAsync(TodoItem todoItem);
            Task DeleteAsync(int id);
        
    }
}
