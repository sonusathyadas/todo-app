using TodoApp.Models;

namespace TodoApp.Services;

public class TodoService : ITodoService
{
    private readonly List<Todo> _todos = new();
    private int _nextId = 1;

    public TodoService()
    {
        // Seed with 5 default todos
        Add(new Todo
        {
            Title = "Buy groceries",
            Description = "Milk, eggs, bread, and coffee",
            IsCompleted = false,
            CreatedAt = DateTime.Now.AddDays(-2)
        });

        Add(new Todo
        {
            Title = "Read a book",
            Description = "Finish 'Clean Code' by Robert Martin",
            IsCompleted = true,
            CreatedAt = DateTime.Now.AddDays(-5)
        });

        Add(new Todo
        {
            Title = "Go for a run",
            Description = "30 minutes around the park",
            IsCompleted = false,
            CreatedAt = DateTime.Now.AddDays(-1)
        });

        Add(new Todo
        {
            Title = "Fix the leaky faucet",
            Description = "Check under the kitchen sink",
            IsCompleted = false,
            CreatedAt = DateTime.Now.AddHours(-3)
        });

        Add(new Todo
        {
            Title = "Call mom",
            Description = "Catch up and check in",
            IsCompleted = true,
            CreatedAt = DateTime.Now.AddDays(-3)
        });
    }

    public List<Todo> GetAll()
    {
        return _todos.OrderBy(t => t.IsCompleted).ThenByDescending(t => t.CreatedAt).ToList();
    }

    public void Add(Todo todo)
    {
        todo.Id = _nextId++;
        todo.CreatedAt = DateTime.Now;
        _todos.Add(todo);
    }

    public void ToggleComplete(int id)
    {
        var todo = _todos.FirstOrDefault(t => t.Id == id);
        if (todo != null)
        {
            todo.IsCompleted = !todo.IsCompleted;
        }
    }

    public void Delete(int id)
    {
        var todo = _todos.FirstOrDefault(t => t.Id == id);
        if (todo != null)
        {
            _todos.Remove(todo);
        }
    }
}
