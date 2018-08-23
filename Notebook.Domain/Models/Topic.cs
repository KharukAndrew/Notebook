using System.Collections.Generic;

namespace Notebook.Domain.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Note> Notes { get; set; }

        public Topic()
        {
            Notes = new List<Note>();
        }
    }
}