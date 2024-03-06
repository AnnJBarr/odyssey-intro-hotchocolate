namespace Odyssey.MusicMatcher;

[GraphQLDescription("A curated collection of tracks designed for a specific activity or mood.")]
public class Playlist(string id, string name, string description)
{
  [GraphQLDescription("The ID for the playlist.")]
  [ID]
  public string Id { get; } = id;

  [GraphQLDescription("The name of the playlist.")]
  public string Name { get; set; } = name;

  [GraphQLDescription("Describes the playlist, what to expect and entices the user to listen.")]
  public string? Description { get; set; } = description;
}