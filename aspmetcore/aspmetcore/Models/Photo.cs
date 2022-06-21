using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspmetcore.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
