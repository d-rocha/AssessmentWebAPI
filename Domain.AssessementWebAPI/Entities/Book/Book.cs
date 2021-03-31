using System.Text.Json.Serialization;

namespace Domain.AssessementWebAPI.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        [JsonIgnore]
        public virtual Author Author { get; set; }
    }
}
