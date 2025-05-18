using EventEaseApp.Models;

namespace EventEaseApp.Services
{
    public class AttendanceService
    {
        private readonly List<AttendanceRecord> _records = new();

        public void MarkAttendance(int eventId, string userName)
        {
            _records.Add(new AttendanceRecord { EventId = eventId, UserName = userName });
        }

        public IEnumerable<AttendanceRecord> GetAttendanceForEvent(int eventId)
            => _records.Where(r => r.EventId == eventId);
    }
}