using System;
using System.Collections.Generic;

namespace Posuda.db;

public partial class Product
{
    public long Article { get; set; }

    public string? Name { get; set; }

    public string? UnitOfMeasure { get; set; }

    public long? Price { get; set; }

    public long? MaxDiscount { get; set; }

    public string? Manufacter { get; set; }

    public string? Vendor { get; set; }

    public string? Category { get; set; }

    public long? CurrentDiscount { get; set; }

    public long? Quantity { get; set; }

    public string? Description { get; set; }

    public string? Image { get; set; }
}
