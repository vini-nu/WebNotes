using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebNotes.WebUI.Models
{
    public class NotesRepository : INotesRepository
    {
        private NoteContext _noteContext;

        public NotesRepository(NoteContext noteContext)
        {
            _noteContext = noteContext;
        }
        public void AddNote(int notebookID, Note newNote)
        {
            var theNotebook = GetNotebookById(notebookID);
            theNotebook.Notes.Add(newNote);
            _noteContext.Notes.Add(newNote);
        }

        public void AddNotebook(Notebook newNotebook)
        {
            _noteContext.NoteBooks.Add(newNotebook);
        }

        public IEnumerable<Notebook> GetAllUserNotebooks(int userID)
        {
            var theNotebooks = _noteContext.NoteBooks
                .Where(p => p.UserID == userID)
                .ToList();

            return theNotebooks;
        }

        public IEnumerable<Note> GetAllUserNotes(int userID)
        {
            var theNotes = _noteContext.Notes
                .Where(p => p.UserID == userID)
                .ToList();

            return theNotes;
        }

        public Notebook GetNotebookById(int Id)
        {
            return _noteContext.NoteBooks
                .Where(p => p.Id == Id)
                .FirstOrDefault();
        }

        public Note GetNoteById(int Id)
        {
            return _noteContext.Notes
                .Where(p => p.Id == Id)
                .FirstOrDefault();
        }

        public bool SaveAll()
        {
            return _noteContext.SaveChanges() > 0;
        }
    }
}
