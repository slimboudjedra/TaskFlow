using Microsoft.EntityFrameworkCore;
using TaskFlow.Models;  

namespace TaskFlow.Data
{
    public class TaskFlowContext : DbContext
    {
        public TaskFlowContext(DbContextOptions<TaskFlowContext> options) : base(options)
        {
        }
        public DbSet<TaskItem> TaskItems { get; set; } = null!;
    }
}
