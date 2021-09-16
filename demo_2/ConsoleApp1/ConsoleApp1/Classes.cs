using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public virtual List<Post> Posts { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        [MaxLength(200)]
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
        public string Abstract { get; set; }
        public virtual Blog Blog { get; set; }
        public virtual ImagemPost Imagens { get; set;  }
    }

    public class ImagemPost
    {
        public int ImagemPostId { get; set; }
        public string caminho { get; set; }

    }

    public class BloggingContext : DbContext
    {
        public BloggingContext(): base("Data Source=HOMOLOGAESCALA;Initial Catalog=teste_demo2;User ID=sa;Password=#escalasoft123")
        {
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }

    public class ImagemPostContext : DbContext
    {
        public ImagemPostContext() : base("Data Source=HOMOLOGAESCALA;Initial Catalog=teste_demo2;User ID=sa;Password=#escalasoft123")
        {
        }
    }

}
