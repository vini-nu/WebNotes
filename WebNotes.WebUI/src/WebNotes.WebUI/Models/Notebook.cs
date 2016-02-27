using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebNotes.WebUI.Models
{
    public class Notebook
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
        public bool DefaultNotebook { get; set; }
        public bool Published { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string ShareKey { get; set; }

        public ICollection<Note> Notes { get; set; }
    }
}
