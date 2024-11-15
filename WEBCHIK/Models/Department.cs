using System;
using System.Collections.Generic;

namespace WEBCHIK.Models;

public partial class Department
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public Guid? ManagerId { get; set; }

    public string? Location { get; set; }
}
