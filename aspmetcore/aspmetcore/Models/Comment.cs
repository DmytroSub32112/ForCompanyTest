using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspmetcore.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int PhotoId { get; set; }
        public Photo Photo { get; set; }
    }
}
