using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class ToDoItemModel
    {
        public int Id { get; set; }
        public string UserID { get; set; }
        [Required(ErrorMessage = "Proszę podać nazwę zadania.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Proszę podać datę.")]
        public DateTime Date { get; set; }
        public DateTime? StartDate {  get; set; }
        public DateTime? EndDate { get; set; }
        public string? Description { get; set; }
    }
}
