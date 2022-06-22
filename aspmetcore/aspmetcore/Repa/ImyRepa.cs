using aspmetcore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspmetcore.Repa
{
    public  interface ImyRepa
    {
        public List<Photo> GetAllPhoto();
        public Photo GetPhoto(int Id);
        public List<Comment> GetComment(int Id);
        public void PostComment(string messege, int Id);
        public void DeleteComment(int id);
    }
}
