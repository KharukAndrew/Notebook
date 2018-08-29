using Notebook.Domain.Models;

namespace Notebook.Web.Models
{
    public class TextViewModel
    {
        //[Key]
        //[ForeignKey("Note")]
        public int Id { get; set; }
        public string Entry { get; set; }

        public Note Note { get; set; }
    }
}