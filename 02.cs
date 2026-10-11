Book book1 = new Book();
book1.Title = "Clean Code";
book1.Author = "Robert C. Martin";
book1.Pages = 464;

Book book2 = new Book();
book2.Title = "The Pragmatic Programmer";
book2.Author = "David Thomas";
book2.Pages = 352;

Book book3 = new Book();
book3.Title = "Refactoring";
book3.Author = "Martin Fowler";
book3.Pages = 448;

List<Book> books = [];
books.Add(book1);
books.Add(book2);
books.Add(book3);

foreach (Book book in books) {
  Console.WriteLine($"{book.Title} - {book.Author} - {book.Pages} pages");
}

class Book {
  public string Title;
  public string Author;
  public int Pages;
}
