using System;
using System.Collections.Generic;

namespace MrV___ng_1;

public partial class Department
{
    public int Id { get; set; }

    public int Building { get; set; }

    public decimal Financing { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Ward> Wards { get; set; } = new List<Ward>();
}
