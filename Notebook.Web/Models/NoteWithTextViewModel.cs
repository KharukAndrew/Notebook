using Notebook.Domain.Models;
using System;

namespace Notebook.Web.Models
{
    public class NoteWithTextViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Header { get; set; }
        public Importance Importance { get; set; }

        public int TopicId { get; set; }
        public string Topic { get; set; }

        public string Text { get; set; }
    }
}