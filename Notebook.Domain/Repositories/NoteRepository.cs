using Notebook.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

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
            //Транзакция записи новой заметки в таблицы Note и Text
            using(var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    db.Notes.Add(item);
                    db.SaveChanges();

                    int newId = item.Id;

                    Text text = new Text
                    {
                        Id = newId,
                        Entry = item.Text.Entry,
                        Note = item
                    };

                    db.Texts.Add(text);
                    db.SaveChanges();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                }
            }
        }

        public Note Details(int id)
        {
            return db.Notes.Include(n => n.Text).Include(n => n.Topic).FirstOrDefault(o => o.Id == id);
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
