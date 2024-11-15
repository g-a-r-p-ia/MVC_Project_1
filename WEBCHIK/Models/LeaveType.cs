using System;
using System.Collections.Generic;

namespace WEBCHIK.Models;

public partial class LeaveType
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public int? MaxDays { get; set; }
}
