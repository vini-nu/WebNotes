using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebNotes.WebUI.Models;

namespace WebNotes.WebUI.Controllers.Api
{
    public class NoteController : Controller
    {
        private NotesRepository _noteRepository;

        public NoteController(NotesRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }
    }
}
