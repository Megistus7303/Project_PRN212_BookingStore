using System;
using System.Collections.Generic;

namespace Project_PRN212.Models;

public partial class Comment
{
    public string CommentId { get; set; } = null!;

    public string BookId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string Comment1 { get; set; } = null!;

    public virtual Book Book { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
