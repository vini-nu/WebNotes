using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebNotes.WebUI.Models;

namespace WebNotes.WebUI.Controllers.Api
{
    public class NoteBookController : Controller
    {
        private NotesRepository _notebookRepository;

        public NoteBookController(NotesRepository notebookRepository)
        {
            _notebookRepository = notebookRepository;
        }
    }
}
