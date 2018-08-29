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
    }
}
