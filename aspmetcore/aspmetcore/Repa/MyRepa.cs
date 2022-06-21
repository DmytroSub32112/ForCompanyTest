using aspmetcore.Entety;
using aspmetcore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspmetcore.Repa
{
    public class MyRepa:ImyRepa
    {
        public List<Photo> GetAllPhoto()
        {
            var collect = new List<Photo>();
            using(var db =new Context())
            {
                collect = db.Photos.ToList();
                return collect;
            }
        }
        public Photo GetPhoto(int Id)
        {
            var photo = new Photo();
            using (var db = new Context())
            {
                photo = db.Photos.Where(c => c.Id == Id).FirstOrDefault();
                return photo;
            }
        }

        public List<Comment> GetComment(int Id)
        {
            var collect = new List<Comment>();
            using(var db = new Context())
            {
                collect = db.Comments.Where(c => c.PhotoId == Id).ToList();
                return collect;
            }
        }
        public void PostComment(string messege,int Id)
        {
            
            using(var db = new Context())
            {
                var findPhoto = db.Photos.Where(c => c.Id == Id).FirstOrDefault();
                var newMessege = new Comment();
                newMessege.PhotoId = Id;
                newMessege.Text = messege;
                db.Comments.Add(newMessege);
                db.SaveChanges();

            }
        }
    }
}
