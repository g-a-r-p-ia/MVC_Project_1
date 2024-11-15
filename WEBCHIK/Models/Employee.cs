using System;
using System.Collections.Generic;

namespace WEBCHIK.Models;

public partial class Employee
{
    public Guid Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Position { get; set; }

    public Guid? DepartmentId { get; set; }

    public DateOnly? HireDate { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public Guid? SupervisorId { get; set; }

    public Guid? PhotoId { get; set; }
    public virtual Photo? Photo { get; set; }
}
