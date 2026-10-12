using System.ComponentModel.DataAnnotations;

namespace TaskFlow.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        [Display(Name = "Titel")]
        [Required(ErrorMessage = "Der Titel ist erforderlich.")]
        [StringLength(100, ErrorMessage = "Der Titel darf maximal 100 Zeichen enthalten.")]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Beschreibung")]
        [StringLength(500, ErrorMessage = "Die Beschreibung darf maximal 500 Zeichen enthalten.")]
        public string? Description { get; set; }

        [Display(Name = "Priorität")]
        [Required]
        public TaskPriority Priority { get; set; } = TaskPriority.Normal;

        [Display(Name = "Status")]
        [Required]
        public TaskStatus Status { get; set; }

        [Display(Name = "Fälligkeitsdatum")]
        [DataType(DataType.Date)]
        public DateTime? DueDate { get; set; }
    }
    public enum TaskPriority
    {
        [Display(Name = "Niedrig")]
        Low,
        [Display(Name = "Normal")]
        Normal,
        [Display(Name = "Hoch")]
        High
    }
    public enum TaskStatus
    {
        [Display(Name = "Zu erledigen")]
        Todo,
        [Display(Name = "In Bearbeitung")]
        InProgress,
        [Display(Name = "Erledigt")]
        Done
    } 
}
