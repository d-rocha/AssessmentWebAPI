using System.Collections.Generic;

namespace Domain.AssessementWebAPI.Entities
{
    public class AuthorBind
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual IList<Book> Books { get; set; }
    }
}
