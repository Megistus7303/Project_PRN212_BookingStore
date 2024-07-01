using System;
using System.Collections.Generic;

namespace Project_PRN212.Models;

public partial class Cart
{
    public string CartId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string BookId { get; set; } = null!;

    public string BookName { get; set; } = null!;

    public string BookImg { get; set; } = null!;

    public double BookPrice { get; set; }

    public int Quantity { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
