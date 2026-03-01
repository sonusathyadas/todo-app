# TodoApp - ASP.NET Core MVC

A clean and modern Todo list application built with ASP.NET Core MVC (.NET 8).

## Features

- ✅ Add, complete, and delete todo items
- 📝 Optional descriptions for each task
- 🎨 Clean Bootstrap 5 UI with icons
- 💾 In-memory storage (singleton service)
- 🔄 Post-Redirect-Get pattern for all forms
- 📊 Task counter showing remaining/total items

## Running the Application

```bash
cd TodoApp
dotnet run
```

Then open your browser to: `https://localhost:5001` or `http://localhost:5000`

## Project Structure

```
TodoApp/
├── Models/
│   └── Todo.cs                    # Todo data model
├── Services/
│   ├── ITodoService.cs            # Service interface
│   └── TodoService.cs             # In-memory service implementation
├── Controllers/
│   └── HomeController.cs          # Main controller with CRUD actions
├── Views/
│   └── Home/
│       └── Index.cshtml           # Single-page todo list view
└── Program.cs                     # Service registration and app config
```

## Default Sample Data

The app comes pre-seeded with 5 sample todos to demonstrate the functionality.
