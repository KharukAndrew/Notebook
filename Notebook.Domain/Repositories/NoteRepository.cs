using Notebook.Domain.Models;
using System;
using System.Collections.Generic;

namespace Notebook.Domain.Repositories
{
    public class NoteRepository : IRepository<Note>, IDisposable
    {
        NotebookDb db = new NotebookDb();

        public IEnumerable<Note> GetAll()
        {
            return db.Notes;
        }

        public Note GetForId(int id)
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
