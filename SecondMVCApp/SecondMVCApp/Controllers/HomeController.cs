using Microsoft.AspNetCore.Mvc;
using SecondMVCApp.Models;
using System.Diagnostics;

namespace SecondMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult AddNewAuthor()
        {
            Author author = new Author();
            return View(author);
        }
        public IActionResult SaveNewAuthor(Author nAuthor)
        {
            string fName = @"D:/Authordata.csv";
            string strAuthor = $"{nAuthor.AuthorID},{nAuthor.AuthorName},{nAuthor.NoOfBooksPublished},{nAuthor.RoyalityCompany}"; // Content to write
            using (StreamWriter sa = new StreamWriter(fName, true))
            {
                sa.WriteLine(strAuthor);
            }
            return View(nAuthor);

        }
        public ActionResult ListAllAuthor()
        {
            String fName = @"D:\Authordata.csv";
            List<Author> list = new List<Author>();
            using (StreamReader sr = new StreamReader(fName))
            {
                string strAuthor = $"{sr.ReadLine()}";
                String[] data = strAuthor.Split(',');
                Author author = StringToAuthor(data, new Author());
                list.Add(author);
                while (!sr.EndOfStream)
                {
                    strAuthor = $"{sr.ReadLine()}";
                    data = strAuthor.Split(",");
                    author = StringToAuthor(data, new Author());
                    list.Add(author);
                }
            }
            return View(list);
        }
        private Author StringToAuthor(String[] data, Author author)
        {
            author.AuthorID = int.Parse(data[0]);
            author.AuthorName = data[1];
            author.NoOfBooksPublished = int.Parse(data[2]);
            author.RoyalityCompany = data[3];
            return author;
        }
    }
}