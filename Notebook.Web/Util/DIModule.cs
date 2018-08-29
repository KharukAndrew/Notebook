using Ninject.Modules;
using Notebook.Domain.Models;
using Notebook.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Notebook.Web.Util
{
    public class DIModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository<Note>>().To<NoteRepository>();
        }
    }
}