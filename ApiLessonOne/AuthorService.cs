using System.ComponentModel.DataAnnotations;

namespace ApiLessonOne;


public class Author

{
    public Author (string email, string name)
    {
        Email = email;
        Name = name;
    }

    public string Email { get; set; }
    public string Name { get; set; }

}



public class AuthorsService
{
    public Author CreateNewAuthor(string email, string name)
    {
        return new Author(email, name);
    }
}
