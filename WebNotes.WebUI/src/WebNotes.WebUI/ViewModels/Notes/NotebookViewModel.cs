using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebNotes.WebUI.Models;

namespace WebNotes.WebUI.ViewModels.Notes
{
    public class NotebookViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool DefaultNotebook { get; set; }
        public bool Published { get; set; }
        public DateTime UpdateDate { get; set; }
        public ICollection<Note> Notes { get; set; }
    }
}
