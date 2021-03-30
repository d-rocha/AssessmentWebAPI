using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.AssessementWebAPI.Entities
{
    public class BookBind
    {
        public int Id { get; set; }
        [Required]
        public string Isbn { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Year { get; set; }
        public virtual Author Author { get; set; }
        public IEnumerable<Author> Authors { get; set; }
    }
}
