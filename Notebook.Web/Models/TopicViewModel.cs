using Notebook.Domain.Models;
using System.Collections.Generic;

namespace Notebook.Web.Models
{
    public class TopicViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Note> Notes { get; set; }

        public TopicViewModel()
        {
            Notes = new List<Note>();
        }
    }
}