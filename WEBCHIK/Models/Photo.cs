using System;
using System.Collections.Generic;

namespace WEBCHIK.Models;

public partial class Photo
{
    public Guid Id { get; set; }

    public string? Img { get; set; }
    public virtual ICollection<Employee> Employee { get; set; } = new List<Employee>();
}
