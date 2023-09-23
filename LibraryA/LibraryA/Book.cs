using System.Reflection.Metadata.Ecma335;

namespace LibraryA
{
    public class Book
    {
        public string Title=String.Empty;
        public string Author=String.Empty;
        public string Genre=String.Empty;
        public DateTime DateOfPublish;
        public int BookPrice;
        public int TotalPages = 300;
        public void OpenBook()
        {
            Console.WriteLine("Book is open");
        }
        public void BookmarkPage(int pageNo)
        {
            Console.WriteLine($"Page No: {pageNo} now BookMarked");
        }
        public int GetCurrentPage()
        {
            Random r= new Random();
            return r.Next(TotalPages);

            Console.WriteLine("Book CLosed");

        }

    }
}