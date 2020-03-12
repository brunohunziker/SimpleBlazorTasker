using Microsoft.AspNetCore.Components;

namespace SimpleBlazorTasker.Pages.Components
{
    public class LoadingBoxBase : ComponentBase
    {
        [Parameter]
        public string DisplayMessage { get; set; }
    }
}