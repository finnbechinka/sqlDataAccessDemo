using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Zusammenfassungsbeschreibung für Mieter
/// </summary>
public class cMieter
{
    public int MieterID { get; set; }
    public string Nachname { get; set; }
    public string Vorname { get; set; }
    public int Tel { get; set; }
    public int WohnungsID { get; set; }

    public string FullInfoMieter
    {
        get
        {
            return MieterID + " " + Nachname + " " + Vorname + " " + WohnungsID + " (" + Tel + ")";
        }
    }
}