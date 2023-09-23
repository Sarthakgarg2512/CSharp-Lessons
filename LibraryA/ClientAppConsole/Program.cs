using LibraryA;

Book book = new Book();
book.Title = "To Kill A Mocking Bird";
Console.WriteLine("Book name is "+ book.Title);
book.Author = "Harper Lee";
Console.WriteLine("Author Name is "+ book.Author);
book.Genre = "Social";
Console.WriteLine("\nBook Genre is "+ book.Genre);

book.OpenBook();

book.BookPrice = 200;
book.DateOfPublish = new DateTime(1995, 06, 01);
book.BookmarkPage(120);


Console.WriteLine("Current Page no. is: " +  book.GetCurrentPage());
Console.WriteLine("Book Closed");

Console.WriteLine("\nCalculator Started");
Calculator calculator=new Calculator();
int addResult=calculator.Add(100, 5);
Console.WriteLine(addResult);
int multiplyResult=calculator.Multiply(110, 5);
Console.WriteLine(multiplyResult);
int divideResult=calculator.Divide(200, 5);
Console.WriteLine(divideResult);
Console.WriteLine("Calculator Stopped");

