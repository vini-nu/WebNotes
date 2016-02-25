using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebNotes.WebUI.Models
{
    public class NoteContext : DbContext
    {
        public NoteContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Notebook> NoteBooks { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<NoteResources> Resources { get; set; }

    }
}
