using System;
using System.Collections.Generic;

namespace StundenplanPruefung.Models;

public partial class Schulzimmer
{
    public int SchulzimmerId { get; set; }

    public string Zimmernummer { get; set; } = null!;

    public virtual ICollection<Stundenplan> Stundenplans { get; set; } = new List<Stundenplan>();
}
