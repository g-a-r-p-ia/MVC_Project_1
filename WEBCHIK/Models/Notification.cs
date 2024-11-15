using System;
using System.Collections.Generic;

namespace WEBCHIK.Models;

public partial class Notification
{
    public Guid Id { get; set; }

    public Guid? RecipientId { get; set; }

    public string? Message { get; set; }

    public DateTime? SentAt { get; set; }
}
