namespace BlazorServerPrerendering.Services;

public class StatsService : IStatsService
{
    public async Task<IEnumerable<Player>> GetMostCareerPoints()
    {
        await Task.Delay(2500);

        return new List<Player>
        {
            new Player("Wayne Gretzky", 1487, 2857),
            new Player("Jaromir Jagr", 1733, 1921),
            new Player("Mark Messier", 1756, 1887),
            new Player("Gordie Hower", 1767, 1850),
            new Player("Ron Francis", 1731, 1798),
            new Player("Marcel Dionne", 1348, 1771),
            new Player("Steve Yzerman", 1514, 1755),
            new Player("Mario Lemieux", 915, 1723),
            new Player("Joe Sakic", 1378, 1641),
            new Player("Sidney Crosby", 1272, 1596)
        };
    }
}
