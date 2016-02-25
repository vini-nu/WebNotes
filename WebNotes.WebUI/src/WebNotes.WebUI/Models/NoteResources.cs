using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebNotes.WebUI.Models
{
    public class NoteResources
    {
        public int Id { get; set; }
        public int NoteId { get; set; }
        //If picture ,width in pixels
        public int Width { get; set; }
        //If picture ,height in pixels
        public int Height { get; set; }
        //If video ,duration in seconds
        public int Duration { get; set; }
        //Check if active Data
        public bool Active { get; set; }
        //Link to cloud storage
        public string UrlToData { get; set; }
    }
}
