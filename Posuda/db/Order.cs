using System;
using System.Collections.Generic;

namespace Posuda.db;

public partial class Order
{
    public long OrderNumber { get; set; }

    public string? Content { get; set; }

    public string? OrderDate { get; set; }

    public long? DeliveryDate { get; set; }

    public byte[]? DeliveryPoint { get; set; }

    public long? ClientName { get; set; }

    public long? Code { get; set; }

    public long? Status { get; set; }
}
