using System.Collections.Generic;
using SimpleBlazorTasker.Entities;

namespace SimpleBlazorTasker.ViewModels
{
  public class TodosViewModel
  {
    public TodosViewModel()
    {
      Todos = new List<TodoItem>
      {
        new TodoItem { Title = "Clean the windows"},
        new TodoItem { Title = "Pay the bills"},
        new TodoItem { Title = "Buy beer"}
      };
    }

    public List<TodoItem> Todos { get; set; }

    public string NewTodo { get; set; }

    public void Create()
    {
      if (!string.IsNullOrWhiteSpace(NewTodo))
      {
        Todos.Add(new TodoItem { Title = NewTodo });
        NewTodo = string.Empty;
      }
    }
  }
}
