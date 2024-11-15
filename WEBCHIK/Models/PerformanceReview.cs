using System;
using System.Collections.Generic;

namespace WEBCHIK.Models;

public partial class PerformanceReview
{
    public Guid Id { get; set; }

    public Guid? EmployeeId { get; set; }

    public DateOnly ReviewDate { get; set; }

    public int? Rating { get; set; }

    public Guid? ReviewerId { get; set; }

    public string? Comments { get; set; }
}
