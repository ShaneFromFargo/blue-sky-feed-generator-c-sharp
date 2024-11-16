namespace bsky_custom_feed.Services;

public interface IFeedGenerator
{
    public Task<List<string>> GenerateFeedSkeleton(string userDid);
}