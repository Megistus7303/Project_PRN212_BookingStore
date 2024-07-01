using System;
using System.Collections.Generic;

namespace Project_PRN212.Models;

public partial class Author
{
    public string AuthorId { get; set; } = null!;

    public string AuthorName { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
