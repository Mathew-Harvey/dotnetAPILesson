
namespace ApiLessonOne;

public class UnitTest1
{
    [Fact]
    public void Test_CanCreateNewAuthor()
    {
        // Arrange
        var authorsService = new AuthorsService();
        var authorEmail = "mat.harvey@rise-x.io";
        var authorName = "Mat Harvey";

        // Act
        var newAuthor = authorsService.CreateNewAuthor(authorEmail, authorName);

        // Asset

        Assert.NotNull(newAuthor);
        Assert.Equal(authorEmail, newAuthor.Email);
        Assert.Equal(authorName, newAuthor.Name);
    }
}