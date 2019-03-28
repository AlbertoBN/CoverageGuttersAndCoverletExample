using System;

namespace ConsumeAndProcess
{
    public class EmployeeTimeCard
    {
        public int EmployeeId { get; set; }
        public DateTime PunchIn { get; set; }
        public DateTime PunchOut { get; set; }
        public int HoursLimit { get; set; }
        public bool IsOvertimeAllowed { get; set; }
        public bool IsValid { get; set; }
    }
}