using System.Text.Json.Serialization;

namespace SimpleApi.Entities;

public class User: IEntityBase
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }

    [JsonIgnore]
    public string? Username { get; set; }

    [JsonIgnore]
    public string? Password { get; set; }
}
