// See https://aka.ms/new-console-template for more information
using System;
using System.Xml.Linq;
public class Book
{
    private string title; private string author;
    private bool isAvailable;
    public string Title
    {
        get { return title; }
        set { title = value; }
    }
    public string Author
    {
        get { return author; }
        set { author = value; }
    }
    public bool IsAvalaible
    {
        get { return isAvailable; }
        set { isAvailable = value; }
    }
    public Book(string atitle, string aauthor)
    {
        Title=atitle;
        Author = author;
        IsAvalaible=true;
    }
    public virtual string GetBookType()
    {
        return "Book";
    }

}
public class User
{
    private string name;
    private int id;
    private int phoneNum;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int ID
    {
        get { return id; }
        set { id = value; }
    }

    public int PhoneNum
    {
        get { return phoneNum; }
        set { phoneNum = value; }
    }

    public User(string aname, int  aid, int aphoneNum)
    {
        Name = aname;
        ID = aid;
        PhoneNum = aphoneNum;
    }
    public void Borrowbook(string Book)
    {
        if (Book.IsAvailable)
        {

        }
    }
}
public class FicBook : Book
{
    private string genre;
    public string Genre;
    {
        get { return genre; }
        set { genre = value; }
    }
    public FicBook(string title, string author, string genre):base(title,author)
    {
        Genre=genre;
    }
    public override string GetBookType()
    {
            return "Fiction";
        }
    }

}

