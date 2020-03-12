using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SimpleBlazorTasker.Entities
{
  public class TaskerDbContext : DbContext
  {
    public DbSet<TodoItem> TodoItems { get; set; }

    public TaskerDbContext(DbContextOptions<TaskerDbContext> options)
      : base(options)
    {
    }
  }
}
