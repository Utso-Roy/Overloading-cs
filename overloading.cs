susing System;
public class Library
{
    string Book;
    string Title;
    string AuthorName;
    double Price;
    long ISBN;
    public Library()
    {
     Book = "Unknown" ;
     Title = "Unknown" ;
     AuthorName = "Unknown" ;
     ISBN = 0 ;
     Price = 0.0 ;
    }
    public Library(string title)
    {
        Title = title;
    }
    public Library(string title,string authorName)
    {
        AuthorName = authorName;
    }
    public Library(string title,string authorName,long isbn)
    {
        ISBN = isbn;
    }
    public Library(string book,string title,string authorName,long isbn,double price)
    {
        Book = book;
        Title = title;
        AuthorName = authorName;
        ISBN = isbn;
        Price = price;    
    }
    public void printInfo()
    {
        Console.WriteLine("Book Name : "+Book);
        Console.WriteLine("Title Name : "+Title);
        Console.WriteLine("Author Name : "+AuthorName);
        Console.WriteLine("ISBN Number : "+ISBN);
        Console.WriteLine("Book Price : "+Price);
    }
    
    static void Main()
    {
        Library b1 = new Library("Harry Potter","Harry Potter and the Chamber of Secrets","J.K. Rowling",8876769,1350);
        b1.printInfo();
    }
   }
