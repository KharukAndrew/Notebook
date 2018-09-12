using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook.Domain.Models
{
    public class InitializerDb : DropCreateDatabaseAlways<NotebookDb>
    {
        protected override void Seed(NotebookDb context)
        {
            Topic topik1 = new Topic { Name = "Films" };
            Topic topik2 = new Topic { Name = "Books" };

            context.Topics.AddRange(new List<Topic> { topik1, topik2 });

            Note note1 = new Note {
                Date = new DateTime(2018, 09, 10),
                Header = "Tests header",
                Topic = topik1              
            };
            context.Notes.Add(note1);

            context.SaveChanges();

            context.Texts.Add(new Text {
                Id = note1.Id,
                Entry = "Tests text for the note",
                Note = note1 });

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
