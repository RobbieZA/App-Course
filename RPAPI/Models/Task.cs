namespace RPAPI.Models
{
    public class Task
    {
        public enum TaskType {check, build, uplift, photo, scan}
        public int Id { get; set; }
        public TaskType Type { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Store Store { get; set; }
        public int StoreId { get; set; }  
    }
}