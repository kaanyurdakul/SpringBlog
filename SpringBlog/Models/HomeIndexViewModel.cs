using SpringBlog.Models;
using System.Collections.Generic;

namespace SpringBlog.Controllers
{
    internal class HomeIndexViewModel
    {
        public ICollection<Post> Posts { get; set; }
    }
}