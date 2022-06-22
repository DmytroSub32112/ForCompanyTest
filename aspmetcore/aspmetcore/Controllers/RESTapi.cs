using aspmetcore.Entety;
using aspmetcore.Models;
using aspmetcore.Repa;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspmetcore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RESTapi : ControllerBase
    {
        ImyRepa repaMethod;
        public RESTapi(ImyRepa imyRepa)
        {
            repaMethod = imyRepa;
        }

        [HttpGet]
        public IEnumerable<Photo> Get()
        {
            
            var photo = repaMethod.GetAllPhoto();
            return photo;

        }
        [HttpGet("{Id}")]
        public Photo GetId(int Id)
        {
            var photo = repaMethod.GetPhoto(Id);
            return photo;

        }
        [Route("/Comment")]
        [HttpGet("/Comment/{Id}")]
        public List<Comment> GetComments(int Id)
        {
            //var comment = new Comment() { Text = "Hello", PhotoId = Id };
            //using(var DB = new Context())
            //{
            //    DB.Comments.Add(comment);
            //    DB.SaveChanges();
            //}
            var comments = repaMethod.GetComment(Id);
            return comments;
        }
        [HttpPost]
        public void PostComment(ForComment forcomment)
        {
            var text = forcomment.text;
            var Id = forcomment.id;
            repaMethod.PostComment(text, Id);
        }
        [HttpDelete("{Id}")]
        public void DeleteComment(int id)
        {
            repaMethod.DeleteComment(id);

        }

    }
    public class ForComment
    {
        public int id { get; set; }
        public string text { get; set; }
    }
}
