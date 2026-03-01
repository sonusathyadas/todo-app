using Microsoft.AspNetCore.Mvc;
using TodoApp.Models;
using TodoApp.Services;

namespace TodoApp.Controllers;

public class HomeController : Controller
{
    private readonly ITodoService _todoService;

    public HomeController(ITodoService todoService)
    {
        _todoService = todoService;
    }

    public IActionResult Index()
    {
        var todos = _todoService.GetAll();
        return View(todos);
    }

    [HttpPost]
    public IActionResult Add(string title, string? description)
    {
        if (!string.IsNullOrWhiteSpace(title))
        {
            var todo = new Todo
            {
                Title = title,
                Description = description,
                IsCompleted = false
            };
            _todoService.Add(todo);
        }
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public IActionResult Toggle(int id)
    {
        _todoService.ToggleComplete(id);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public IActionResult Delete(int id)
    {
        _todoService.Delete(id);
        return RedirectToAction(nameof(Index));
    }
}
