using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebNotes.WebUI.Models
{
    public interface INotesRepository
    {
        IEnumerable<Notebook> GetAllUserNotebooks(int userID);
        IEnumerable<Note> GetAllUserNotes(int userID);
        void AddNotebook(Notebook newNotebook);
        void AddNote(int notebookID, Note newNote);
        bool SaveAll();
        Notebook GetNotebookById(int Id);
        Note GetNoteById(int Id);
    }
}
