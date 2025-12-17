using System;
using System.Collections.Generic;

namespace StundenplanPruefung.Models;

public partial class Fach
{
    public int FachId { get; set; }

    public string Fachname { get; set; } = null!;

    public virtual ICollection<Stundenplan> Stundenplans { get; set; } = new List<Stundenplan>();
}
