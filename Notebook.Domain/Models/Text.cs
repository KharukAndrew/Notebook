using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Notebook.Domain.Models
{
    public class Text
    {
        [Key]
        [ForeignKey("Note")]
        public int Id { get; set; }
        public string Entry { get; set; }

        public Note Note { get; set; }
    }
}