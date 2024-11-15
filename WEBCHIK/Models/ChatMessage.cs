using System;
using System.Collections.Generic;

namespace WEBCHIK.Models;

public partial class ChatMessage
{
    public Guid Id { get; set; }

    public Guid? ChatId { get; set; }

    public Guid? SenderId { get; set; }

    public string? Message { get; set; }

    public DateTime? SentAt { get; set; }
}
