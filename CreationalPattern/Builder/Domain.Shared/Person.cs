using System.Security.Cryptography;
namespace Builder;

public record Person
{

    public DateTime BirthDate { get;  }
    public string Name { get;  }
    public string Document { get;  }
    

    public Person(string name, DateTime birthDate, string document)
    {
        Name = SetName(name);
        BirthDate = birthDate.Date;
        Document = SetDocument(document);
    }
    
    private string SetDocument(string document)
    {
        document = document.Trim().Replace('.', ' ')
            .Replace('-', ' ')
            .Replace(';', ' ');

        if (document.ToCharArray().Any(char.IsLetter) || document.Length != 11)
            throw new ApplicationException("Not a valid document");

        return document;
    }

    private string SetName(string name)
    {
        name = name.Trim();
        if (string.IsNullOrEmpty(name))
            throw new ArgumentException("Name cannot be empty");

        return name;
    }
}