using System.Collections.Generic;
using SimpleBlazorTasker.Entities;

namespace SimpleBlazorTasker.ViewModels
{
  public class TodosViewModel
  {
    public TodosViewModel()
    {
      ToDos = new[] 
      {
        new Todo { Content = "Clean the windows"},
        new Todo { Content = "Pay the bills"},
        new Todo { Content = "Buy beer"}
      };
    }

    public IEnumerable<Todo> ToDos { get; set; }
  }
}
