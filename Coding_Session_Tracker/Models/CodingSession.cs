using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Session_Tracker.Models
{
    public class CodingSession
    {
        public int Id { get; set; }
        public string StartTime { get; set; } // Stored as string for SQLite
        public string EndTime { get; set; }
        public string Duration { get; set; }
    }
}
