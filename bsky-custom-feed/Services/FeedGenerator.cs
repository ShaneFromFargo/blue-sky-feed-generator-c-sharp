namespace bsky_custom_feed.Services;

public class FeedGenerator : IFeedGenerator
{
    public async Task<List<string>> GenerateFeedSkeleton(string userDid)
    {
        // Replace with custom algorithm logic.
        var postUris = new List<string>
        {
            "at://s-h-a-n-e.bsky.social/post/3lasitththd2l",
            "at://lindaadler.bsky.social/post/3law6vkpxck2y",
            "at://jaymgates.bsky.social/post/3l4apmmleuu2f"
        };
        return postUris;
    }
}