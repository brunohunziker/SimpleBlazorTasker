using System.ComponentModel.DataAnnotations;

namespace SimpleBlazorTasker.Entities
{
  public class TodoItem
  {
    public long Id { get; set; }

    [Required]
    public string Title { get; set; }

    public bool IsDone { get; set; }
  }
}
