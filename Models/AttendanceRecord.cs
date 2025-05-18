namespace EventEaseApp.Models
{
    public class AttendanceRecord
    {
        public int EventId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public DateTime AttendedOn { get; set; } = DateTime.Now;
    }
}