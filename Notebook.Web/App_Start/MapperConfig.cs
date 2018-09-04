using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace Notebook.Web.App_Start
{
    public class MapperConfig
    {
        public static void ConfigureMapping()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Notebook.Domain.Models.Note, Notebook.Web.Models.NoteViewModel>();
                cfg.CreateMap<Notebook.Web.Models.TopicViewModel, Notebook.Domain.Models.Topic>();
            });
        }
    }
}