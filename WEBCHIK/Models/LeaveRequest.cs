using System;
using System.Collections.Generic;

namespace WEBCHIK.Models;

public partial class LeaveRequest
{
    public Guid Id { get; set; }

    public Guid? EmployeeId { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public Guid? LeaveTypeId { get; set; }

    public string? Status { get; set; }

    public DateTime? SubmittedAt { get; set; }

    public Guid? ApprovedBy { get; set; }

    public string? Comment { get; set; }
}
