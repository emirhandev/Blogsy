using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EmirhanBlog.Models;

namespace EmirhanBlog.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly BlogContext _context;

    public HomeController(ILogger<HomeController> logger,BlogContext context)
    {
        _logger = logger;
        _context=context;
    }


  

    public IActionResult Index()
    {
        var list = _context.Blog.Take(4).Where(b=>b.IsPublish).OrderByDescending(b =>b.CreatedTime).ToList();
        foreach (var blog in list)
        {
            blog.Author =_context.Author.Find(blog.AuthorId);
            
        }
        return View(list);
    }
       public IActionResult AllPosts()
    {
        var list = _context.Blog.Take(_context.Blog.ToList().Count).Where(b=>b.IsPublish).OrderByDescending(b =>b.CreatedTime).ToList();
        foreach (var blog in list)
        {
            blog.Author =_context.Author.Find(blog.AuthorId);
            
        }
        return View(list);
    }
        public IActionResult Authors()
    {
       List <Author> list = _context.Author.ToList();
        return View(list);
    }
 public IActionResult AuthorPosts(int Id)
{
   
     var list = _context.Blog.Take(_context.Blog.ToList().Count).Where(b=>b.IsPublish&&b.AuthorId==Id).OrderByDescending(b =>b.CreatedTime).ToList();
        foreach (var blog in list)
        {
            blog.Author =_context.Author.Find(blog.AuthorId);
            
        }
        return View(list);
}

   public IActionResult About()
    {
      
        return View();
    }
       public IActionResult Contact()
    {
      
        return View();
    }

    public IActionResult Post(int Id)
    {
        var blog=_context.Blog.Find(Id);
        blog.Author=_context.Author.Find(blog.AuthorId);
        blog.ImagePath="/img/BlogPostImages/"+blog.ImagePath;
        return View(blog);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
