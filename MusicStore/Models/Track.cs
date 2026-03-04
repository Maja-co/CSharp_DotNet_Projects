namespace MusicStore.Models;

public class Track
{
    public string Title { get; set; }
    public string Composer { get; set; }
    public string Length { get; set; }

    public Track(string title, string composer, string length)
    {
        Title = title;
        Composer = composer;
        Length = length;
    }

    public override string ToString()
    {
        return $"{Title} - ({Length})";
    }
    
    
}