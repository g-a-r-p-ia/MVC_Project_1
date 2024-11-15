using System;
using System.Collections.Generic;

namespace WEBCHIK.Models;

public partial class Chat
{
    public Guid Id { get; set; }

    public Guid? EmployeeId1 { get; set; }

    public Guid? EmployeeId2 { get; set; }
}
