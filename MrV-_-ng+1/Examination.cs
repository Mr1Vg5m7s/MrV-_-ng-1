using System;
using System.Collections.Generic;

namespace MrV___ng_1;

public partial class Examination
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<DoctorsExamination> DoctorsExaminations { get; set; } = new List<DoctorsExamination>();
}
