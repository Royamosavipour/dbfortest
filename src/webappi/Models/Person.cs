using System;
using System.Collections.Generic;

namespace webappi.Models;

public partial class Person
{
    public int Personid { get; set; }

    public string LastName { get; set; } = null!;

    public string? FirstName { get; set; }

    public int? Age { get; set; }
}
