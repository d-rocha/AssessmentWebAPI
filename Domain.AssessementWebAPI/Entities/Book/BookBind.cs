using System.Collections.Generic;

namespace Domain.AssessementWebAPI.Entities
{
    public class BookBind
    {
        public int Id { get; set; }
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public virtual Author Author { get; set; }
        public IEnumerable<Author> Authors { get; set; }
    }
}
