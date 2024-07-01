using System;
using System.Collections.Generic;

namespace Project_PRN212.Models;

public partial class Order
{
    public string OrderId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string BookId { get; set; } = null!;

    public int Quantity { get; set; }

    public string OrderStatus { get; set; } = null!;

    public virtual Book Book { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
