using Interactive.Service.Contract;
using System;

namespace Interactive.Service.Implementation
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}