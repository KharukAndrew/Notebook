using Notebook.Domain.Models;
using System;
using System.Collections.Generic;

namespace Notebook.Domain.Repositories
{
    public class NoteRepository : IRepository<Note>, IDisposable
    {
        //здесь создается общий db для всех действий и переопределяется метод Dispose
        //для Topic db создается отдельно в каждом действии в конструкции using.
        //что лучше?
        NotebookDb db = new NotebookDb();

        public IEnumerable<Note> GetAll()
        {
            return db.Notes;
        }

        public Note GetForId(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Note item)
        {
            throw new NotImplementedException();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
