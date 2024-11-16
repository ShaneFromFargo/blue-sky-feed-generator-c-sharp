using bsky_custom_feed.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace bsky_custom_feed.Controllers;
[ApiController]
[Microsoft.AspNetCore.Components.Route("[controller]")]
public class FeedController : ControllerBase
{
    private readonly IFeedGenerator _feedGenerator;

    public FeedController(IFeedGenerator feedGenerator)
    {
        _feedGenerator = feedGenerator;
    }
    
    [HttpGet("getFeedSkeleton")]
    public async Task<IActionResult> GetFeedSkeleton([FromQuery] string userDid)
    {
        var feedSkeleton = await _feedGenerator.GenerateFeedSkeleton(userDid);
        return Ok(feedSkeleton);
    }
}