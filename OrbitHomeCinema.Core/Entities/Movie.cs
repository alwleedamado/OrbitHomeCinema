namespace OrbitHomeCinema.Core.Entities;

public class Movie : EntityBase
{
    public string Name { get; set; } = string.Empty;
    public TimeSpan Duration { get; set; }
}
