namespace OrbitHomeCinema.Core.Entities;

public class Series : EntityBase
{
    public string Name { get; set; }
    public List<SeriesSeason> Seasons { get; set; } = [];
}
