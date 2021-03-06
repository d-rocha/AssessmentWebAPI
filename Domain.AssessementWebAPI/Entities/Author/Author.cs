using System.Collections.Generic;

namespace Domain.AssessementWebAPI.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Dob { get; set; }        
        public virtual IList<Book> Books { get; set; }
    }
}
