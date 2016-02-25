using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebNotes.WebUI.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HigherLevelId { get; set; }
        //higherlevelId->if using parental tags
        public ICollection<Note> NotesWithTag { get; set; }
    }
}
