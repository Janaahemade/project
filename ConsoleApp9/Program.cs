// See https://aka.ms/new-console-template for more information

using System.Xml.Linq;
abstract public class Libararycard
{
    public abstract void showcardtitle();
    
}
public class Viplibrarycard: Libararycard
{
    public override void showcardtitle()
    {
        Console.WriteLine("vip card");   }
}
public class userlibrarycard : Libararycard
{
    public override void showcardtitle()
    {
        Console.WriteLine("user card");
    }
}
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
        Author = aauthor;
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
    private List<string> borrowedBooks = new List<string>();
    private List<string> returnedBooks = new List<string>();
    
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

    public User(string aname, int aid, int aphoneNum)
    {
        Name = aname;
        ID = aid;
        PhoneNum = aphoneNum;
        borrowedBooks = new List<string>();
        returnedBooks = new List<string>();
    }
    public void Borrowbook(string Booktitle)
    {
        borrowedBooks.Add(Booktitle);
        Console.WriteLine($"{name} have borrowed \"{Booktitle}\".");
    }
    public void ReturnBook(string Booktitle)
    {
        returnedBooks.Add(Booktitle);
        borrowedBooks.Remove(Booktitle);
        Console.WriteLine($"{name} have returned \"{Booktitle}\".");
    }
    public void printborrowedbooks()
    {
        Console.WriteLine($"User: {name}");
        Console.WriteLine("------------------borrrowed books---------------------");
        foreach( string Booktitle in borrowedBooks)
        { Console.WriteLine(Booktitle); }   
    }
    public void printreturnedbooks()
    {
        Console.WriteLine($"User: {name}");
        Console.WriteLine("------------------returned books---------------------");
        foreach (string Booktitle in returnedBooks)
        { Console.WriteLine(Booktitle); }
    }
}
public class FicBook : Book
{
    public string Genre {
        get; set;
    }
    public FicBook(string title, string author, string genre) : base(title, author)
    {
        Genre=genre;
    }
    public override string GetBookType()
    {
        return "Fiction";
    }
}

class Progrm
{
    static void Main(string[] args)
    {
        User user1 = new("omar", 21100546, 012781232);
        User user2 = new("Malak", 2774356, 011321765);
        User user3 = new("Ahmed", 2453567, 0105114356);
        Book Book1 = new Book("Black  Beauty", "william Shakespear");
        Book Book2 = new Book("only the Brave", "Danielle Steel");
        FicBook fictionBook = new FicBook("The Hobbit", "J.R.R. Tolkien", "Fantasy");

        // The user should be able to borrow books and return books.
        Console.WriteLine("requirment: The user should be able to borrow books and return books.");
        user1.Borrowbook(Book1.Title);
        user2.Borrowbook(Book2.Title);
        user1.ReturnBook(Book1.Title);
        user2.ReturnBook(Book2.Title);
        user3.Borrowbook(Book1.Title);
        user3.Borrowbook(Book2.Title);
        user3.Borrowbook(fictionBook.Title);
        Console.WriteLine("---------------------------------------");
        //The profile must have information about the user’s borrowed books
        Console.WriteLine("requirment:The profile must have information about the user’s borrowed books");
        Console.WriteLine();
        user3.printborrowedbooks();
        Console.WriteLine();
        user1.printreturnedbooks();
        //Abstraction
        Console.WriteLine("---------------------------------------");
        Viplibrarycard Card1 = new Viplibrarycard();
        userlibrarycard card2= new userlibrarycard();
        Card1.showcardtitle();
        Console.WriteLine();
        card2.showcardtitle();


    }
}


