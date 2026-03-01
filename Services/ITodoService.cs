using TodoApp.Models;

namespace TodoApp.Services;

public interface ITodoService
{
    List<Todo> GetAll();
    void Add(Todo todo);
    void ToggleComplete(int id);
    void Delete(int id);
}
