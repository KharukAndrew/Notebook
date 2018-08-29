using System.Data.Entity;

namespace Notebook.Domain.Models
{
    public class NotebookDb : DbContext
    {
        public NotebookDb()
            : base("name=NotebookDb")        
        {
        }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<Text> Texts { get; set; }
    }

}