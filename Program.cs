using System;
using System.Collections.Generic;

Book book1 = new Book("Billy","20,000 Leagues Under the Sea",new DateTime(2012, 12, 12),29);
Book book2 = new Book("John", "The Best Book Ever", new DateTime(1200, 1,1), 99999999);
Book book3 = new Book("Joe","The Book of Cool Stuff",new DateTime(1999, 12, 31),10);


Library myLibrary = new Library("Mason's Library");


myLibrary.AddBook(book1);
myLibrary.AddBook(book2);
myLibrary.AddBook(book3);


myLibrary.ListLibrary();

public class Book
{
    public string Author {get; set;}
    public string Title { get; set; }
    public DateTime PublishDate { get; set; }
    public int NumOfPages { get; set; }
    public string DisplayName 
    { 
        get { return $"{Title} - by {Author}";}
    }
    
    public Book(string author, string title, DateTime DatePublished, int NumberPages)
    {
        Author = author;
        Title = title;
        PublishDate = DatePublished;
        NumOfPages = NumberPages;
    }
}

public class Library
{
    public string Name { get; set; }

    private List<Book> _bookList = new List<Book>();

    public Library(string name)
    {
        Name = name;
    }
    public void AddBook(Book aBook)
    {
        _bookList.Add(aBook);
    }

    public void ListLibrary()
    {
        foreach (Book book in _bookList)
        {
            Console.WriteLine($"{book.DisplayName}");
        }
    }
}
