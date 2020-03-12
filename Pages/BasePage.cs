using Microsoft.AspNetCore.Components;

namespace SimpleBlazorTasker.Pages
{
  public class BasePage<T> : ComponentBase
  {
    [Inject] protected T VM { get; set; }
  }
}