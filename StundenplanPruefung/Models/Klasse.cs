using System;
using System.Collections.Generic;

namespace StundenplanPruefung.Models;

public partial class Klasse
{
    public int KlasseId { get; set; }

    public string Klassenname { get; set; } = null!;

    public virtual ICollection<Stundenplan> Stundenplans { get; set; } = new List<Stundenplan>();
}
