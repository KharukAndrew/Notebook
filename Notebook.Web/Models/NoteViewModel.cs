using Notebook.Domain.Models;
using System;

namespace Notebook.Web.Models
{
    public class NoteViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Header { get; set; }

        public int TopicId { get; set; }
        public Topic Topic { get; set; }

        public Text Text { get; set; }
    }
}