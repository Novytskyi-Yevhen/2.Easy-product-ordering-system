using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewTask.Services
{
    public class SimpleTimeService : ITimeService
    {
        public DateTime GetTimeForTomorrow()
        {
            return DateTime.Now.Subtract(new TimeSpan(1, 0, 0, 0));
        }
    }
}
