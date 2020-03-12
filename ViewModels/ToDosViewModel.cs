using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleBlazorTasker.Entities;

namespace SimpleBlazorTasker.ViewModels
{
  public class TodosViewModel
  {
    private readonly TaskerDbContext _dbContext;

    public TodosViewModel(TaskerDbContext dbContext)
    {
      _dbContext = dbContext;
      Todos = _dbContext.TodoItems.ToList();
    }

    public List<TodoItem> Todos { get; set; }

    public string NewTodo { get; set; }

    public void Create()
    {
      if (string.IsNullOrWhiteSpace(NewTodo)) return;

      _dbContext.TodoItems.Add(new TodoItem { Title = NewTodo });
      _dbContext.SaveChanges();
      Todos = _dbContext.TodoItems.ToList();

      NewTodo = string.Empty;
    }

    public async Task Load()
    {
      Todos = await _dbContext.TodoItems.ToListAsync();
    }
  }
}
