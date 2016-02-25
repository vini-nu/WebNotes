using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebNotes.WebUI.Models
{
    public class Accounting
    {
        public int Id { get; set; }
        public int NotesLimit { get; set; }
        public DateTime NotesLimitsReset { get; set; }
        public int NextNotesLimit { get; set; }
        public bool Premium { get; set; }
        public DateTime PremiumEnd { get; set; }
        public string PremiumCode { get; set; }
        public string Currency { get; set; }
        public string PremiumUserName { get; set; }
    }
}
