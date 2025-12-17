using System;
using System.Collections.Generic;

namespace StundenplanPruefung.Models;

public partial class Lehrer
{
    public int LehrerId { get; set; }

    public string Vorname { get; set; } = null!;

    public string Nachname { get; set; } = null!;

    public virtual ICollection<Stundenplan> Stundenplans { get; set; } = new List<Stundenplan>();
}
