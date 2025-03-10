namespace OrbitHomeCinema.Core.Entities;

public class Episode : EntityBase
{
    public Guid SeasonId { get; set; }
    public string? Title { get; set; }
    public int EpisodeNumber {  get; set; }
    public TimeSpan Duration { get; set; }
}
