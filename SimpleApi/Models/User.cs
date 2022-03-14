namespace SimpleApi.Models
{
    public class User: IEntityBase
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Title { get; set; }
    }
}
