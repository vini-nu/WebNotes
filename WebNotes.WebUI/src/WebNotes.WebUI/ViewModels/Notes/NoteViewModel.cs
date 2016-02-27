﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebNotes.WebUI.Models;

namespace WebNotes.WebUI.ViewModels.Notes
{
    public class NoteViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public bool Published { get; set; }
        public DateTime UpdateDate { get; set; }

        public ICollection<NoteResources> Resources { get; set; }
    }
}
