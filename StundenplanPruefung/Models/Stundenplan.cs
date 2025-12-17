using System;
using System.Collections.Generic;

namespace StundenplanPruefung.Models;

public partial class Stundenplan
{
    public int StundenplanId { get; set; }

    public int KlasseId { get; set; }

    public int LehrerId { get; set; }

    public int FachId { get; set; }

    public int SchulzimmerId { get; set; }

    public string Wochentag { get; set; } = null!;

    public int Lektion { get; set; }

    public virtual Fach Fach { get; set; } = null!;

    public virtual Klasse Klasse { get; set; } = null!;

    public virtual Lehrer Lehrer { get; set; } = null!;

    public virtual Schulzimmer Schulzimmer { get; set; } = null!;
}
