using System.Threading.Tasks;
using SimpleBlazorTasker.ViewModels;

namespace SimpleBlazorTasker.Pages
{
  public class IndexBase : BasePage<TodosViewModel>
  {
    protected override async Task OnInitializedAsync()
    {
      await VM.Load();
    }
  }
}
