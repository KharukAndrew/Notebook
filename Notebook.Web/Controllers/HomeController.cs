using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using Notebook.Domain.Models;
using Notebook.Domain.Repositories;
using Notebook.Web.Models;

namespace Notebook.Web.Controllers
{
    public class HomeController : Controller
    {
        IRepository<Topic> _repositoryTopic;
        IRepository<Note> _repositoryNote;
        IRepository<Text> _repositoryText;

        public HomeController(IRepository<Note> repoNote, IRepository<Topic> repoTopic)
        {
            _repositoryNote = repoNote;
            _repositoryTopic = repoTopic;
        }

        public ActionResult Index()
        {
            ViewBag.Topic = _repositoryTopic.GetAll();

            IEnumerable<Note> notes = _repositoryNote.GetAll();
            return View(Mapper.Map< IEnumerable<NoteViewModel>>(notes));
        }

        public ActionResult CreateNote()
        {
            NoteWithTextViewModel note = new NoteWithTextViewModel
            {
                Date = DateTime.Now
            };

            return View(note);
        }

        [HttpPost]
        public ActionResult CreateNote(NoteWithTextViewModel noteWithText)
        {
            //TODO: переделать с использованием AutoMapper
            Note note = new Note
            {
                Date = noteWithText.Date,
                Header = noteWithText.Header,
                TopicId = noteWithText.TopicId,
                Text = new Text { Entry = noteWithText.Text }
            };

            _repositoryNote.Add(note);
            
            return RedirectToAction("Index"); 
        }


        public ActionResult DetailsNote(int id)
        {
            Note note = _repositoryNote.Details(id);

            //TODO: сопоставление надо через Automapper
            NoteWithTextViewModel noteViewModel = new NoteWithTextViewModel
            {
                Id = note.Id,
                Date = note.Date,
                Header = note.Header,
                TopicId = note.TopicId,
                Text = note.Text.Entry
            };

            return View(noteViewModel);
        }

        //Action for Topic
        public ActionResult CreateTopic()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTopic(TopicViewModel topicViewModel)
        {
            _repositoryTopic.Add(Mapper.Map<Topic>(topicViewModel));
            return RedirectToAction("Index");
        }
    }
}