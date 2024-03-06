namespace Odyssey.MusicMatcher.Types;

[GraphQLDescription("A curated collection of tracks designed for a specific activity or mood.")]
public class Playlist
{
  private readonly string _id;
  private string _name;
  private string _description;

  public Playlist(string id, string name, string description)
  {
    _id = id;
    _name = name;
    _description = description;
  }

  [GraphQLDescription("The ID for the playlist.")]
  [ID]
  public string Id
  {
    get { return _id; }
  }

  [GraphQLDescription("The name of the playlist.")]
  public string Name
  {
    get { return _name; }
    set { _name = value; }
  }

  [GraphQLDescription("Describes the playlist, what to expect and entices the user to listen.")]
  public string? Description
  {
    get { return _description; }
    set { _description = value; }
  }
}