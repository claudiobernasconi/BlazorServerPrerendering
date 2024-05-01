namespace BlazorServerPrerendering.Services;

public interface IStatsService
{
    Task<IEnumerable<Player>> GetMostCareerPoints();
}

public record Player(string Name, int GamesPlayed, int Points);
