namespace MusicStore.Models;

public class MusicCD : Product {
    public string Artist { get; set; }
    public string Label { get; set; }
    public short Released { get; set; }
    public List<Track> TrackList { get; set; }


    public MusicCD(string title, double price, string manufacturer) : base(title, price, manufacturer) {
        TrackList = new List<Track>();
    }

    public MusicCD(string title, double price, string manufacturer, List<string> tracks, string artist, string label,
        short released) : base(title, price, manufacturer) {
        TrackList = new List<Track>();
        Artist = artist;
        Label = label;
        Released = released;
    }

    public MusicCD(string title, double price, string artist, short released) : base(title, price) {
        Artist = artist;
        Released = released;
    }

    public void AddTrack(string title) {
        TrackList.Add(new Track(title, "", ""));
    }

    public void AddTrack(string title, string composer, string length) {
        TrackList.Add(new Track(title, composer, length));
    }

    public void AddTrack(string title, string length) {
        TrackList.Add(new Track(title, "", length));
    }
}