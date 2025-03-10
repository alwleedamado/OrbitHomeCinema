namespace OrbitHomeCinema.Core.Entities;

internal class SeriesSeason : EntityBase
{
    public Guid SeriesId { get; set; }
    public string? Title { get; set; }
    public List<Episode> Episodes { get; set; } = [];
}
