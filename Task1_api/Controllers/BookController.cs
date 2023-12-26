using Microsoft.AspNetCore.Mvc;

namespace Task1_api.Controllers;

[ApiController]
[Route("[controller]s")]
public class BookController : ControllerBase
{
    private static List<Book> BookList = new List<Book>()
    {
        new Book{
            Id = 1,
            Title = "Lean Startup",
            GenreId = 1, //PErsonal Growth
            PageCount = 200,
            PublishDate = new DateTime(2006, 1,12)
        },
        new Book{
            Id = 2,
            Title = "Herland",
            GenreId = 2,
            PageCount = 345,
            PublishDate = new DateTime(1995,6 , 4)
        },new Book{
            Id = 3,
            Title = "Dune",
            GenreId = 2,
            PageCount = 234,
            PublishDate = new DateTime(1654, 2, 3)
        }
    };

    [HttpGet]
    public List<Book> GetBooks(){
        var bookList = BookList.OrderBy(x => x.Id).ToList<Book>();
        return bookList;
    }
}