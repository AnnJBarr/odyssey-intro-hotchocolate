namespace Odyssey.MusicMatcher.Types;

public class Query
{
    [GraphQLDescription("Returns some AMAZING playlists, not awful ones - all awesome")]
    public List<Playlist> FeaturedPlaylists()
    {
        return
        [
            new Playlist("1", "Suggestive Reading", "for those quiet moments"),
            new Playlist("2", "No Swears", "suitable for car trips with young relatives"),
            new Playlist("3", "Hip Hop, Grime", "does what it says on the tin")
        ];
    }
}