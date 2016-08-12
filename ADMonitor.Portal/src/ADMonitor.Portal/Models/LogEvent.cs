using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ADMonitor.Portal.Models
{
    public class LogEvent
    {
        [Key]
        public Guid Id { get; set; }

        public string User { get; set; }

        public DateTime logTime { get; set; }

        public string Client { get; set; }

        public string EventType { get; set; }

        public DateTime Date { get; set; }
    }
}
