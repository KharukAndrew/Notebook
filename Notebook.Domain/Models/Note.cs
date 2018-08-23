using System;

namespace Notebook.Domain.Models
{
    public class Note
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Header { get; set; }

        public int TopicId { get; set; }
        public Topic Topic { get; set; }

        public Text Text { get; set; }
    }
}