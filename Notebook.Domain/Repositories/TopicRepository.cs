using Notebook.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook.Domain.Repositories
{
    public class TopicRepository : IRepository<Topic>
    {
        public IEnumerable<Topic> GetAll()
        {
            IEnumerable<Topic> topics = new List<Topic>();

            using (NotebookDb db = new NotebookDb())
            {
                topics = db.Topics.ToList();
            }
            return topics;
        }

        public Topic GetForId(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Topic item)
        {
            using (NotebookDb db = new NotebookDb())
            {
                db.Topics.Add(item);
                db.SaveChanges();
            }
        }

        public Topic Details(int id)
        {
            throw new NotImplementedException();
        }


        //private bool disposed = false;

        //public virtual void Dispose(bool disposing)
        //{
        //    if (!this.disposed)
        //    {
        //        if (disposing)
        //        {
        //            db.Dispose();
        //        }
        //        this.disposed = true;
        //    }
        //}

        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}
    }
}
