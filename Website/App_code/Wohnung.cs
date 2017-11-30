using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Zusammenfassungsbeschreibung für Wohnung
/// </summary>
public class Wohnung
{
    public int WohnungsID { get; set; }
    public int HausID { get; set; }
    public int Stockwerk { get; set; }
    public int Größe { get; set; }

    public string FullInfoWohnung
    {
        get
        {
            return WohnungsID + " " + HausID + " " + Stockwerk + " " + Größe;
        }
    }
}