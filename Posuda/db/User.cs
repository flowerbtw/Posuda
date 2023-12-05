using System;
using System.Collections.Generic;

namespace Posuda.db;

public partial class User
{
    public string? Role { get; set; }

    public string Name { get; set; } = null!;

    public string? Login { get; set; }

    public string? Password { get; set; }
}
