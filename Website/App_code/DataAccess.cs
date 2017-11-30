using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Dapper;


/// <summary>
/// Zusammenfassungsbeschreibung für DataAccess
/// </summary>
public class DataAccess
{
    public List<Haus> GetHäuser(string bezeichnung)
    {
        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FinnDB")))
        {
            ///var output = connection.Query<Haus>($"select * from Häuser where Bezeichnung = '{ bezeichnung }'").ToList();
            var output = connection.Query<Haus>("dbo.Häuser_GetByBezeichnung @Bezeichnung", new { Bezeichnung = bezeichnung }).ToList();
            return output;
        }
    }

    public void InsertHaus(string bezeichnung, string adresse, string hausmeisterTel)
    {
        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FinnDB")))
        {
            ///Haus newHaus = new Haus { Bezeichnung = bezeichnung, Adresse = adresse, HausmeisterTel = hausmeisterTel };
            List<Haus> häuser = new List<Haus>();

            häuser.Add(new Haus { Bezeichnung = bezeichnung, Adresse = adresse, HausmeisterTel = Convert.ToInt32(hausmeisterTel) });

            connection.Execute("dbo.Häuser_InsertHaus @Bezeichnung, @Adresse, @HausmeisterTel", häuser);
        }
    }

    public void UpdateHaus(string hausID, string bezeichnung, string adresse, string hausmeisterTel)
    {
        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FinnDB")))
        {
            List<Haus> häuser = new List<Haus>();

            häuser.Add(new Haus { HausID = Convert.ToInt32(hausID), Bezeichnung = bezeichnung, Adresse = adresse, HausmeisterTel = Convert.ToInt32(hausmeisterTel) });

            connection.Execute("dbo.Häuser_UpdateByHausID @HausID, @Bezeichnung, @Adresse, @HausmeisterTel", häuser);
        }
    }

    public void DeleteHaus(string hausID)
    {
        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FinnDB")))
        {
            List<Haus> häuser = new List<Haus>();

            häuser.Add(new Haus { HausID = Convert.ToInt32(hausID) });

            connection.Execute("dbo.Häuser_DeleteByHausID @HausID", häuser);
        }
    }

    public List<cMieter> GetMieter(string nachname)
    {
        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FinnDB")))
        {
            var output = connection.Query<cMieter>("dbo.Mieter_GetByNachname @Nachname", new { Nachname = nachname }).ToList();
            return output;
        }
    }

    public void InsertMieter(string nachname, string vorname, string tel, string wohnungsID)
    {
        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FinnDB")))
        {
            List<cMieter> mieter = new List<cMieter>();

            mieter.Add(new cMieter { Nachname = nachname, Vorname = vorname, Tel = Convert.ToInt32(tel), WohnungsID = Convert.ToInt32(wohnungsID) });

            connection.Execute("dbo.Mieter_InsertMieter @Nachname, @Vorname, @Tel, @WohnungsID", mieter);
        }
    }

    public void DeleteMieter(string mieterID)
    {
        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FinnDB")))
        {
            List<cMieter> mieter = new List<cMieter>();

            mieter.Add(new cMieter { MieterID = Convert.ToInt32(mieterID) });

            connection.Execute("dbo.Mieter_DeleteByMieterID @MieterID", mieter);
        }
    }

    public void UpdateMieter(string mieterID, string nachname, string vorname, string tel, string wohnungsID)
    {
        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FinnDB")))
        {
            List<cMieter> mieter = new List<cMieter>();

            mieter.Add(new cMieter { MieterID = Convert.ToInt32(mieterID), Nachname = nachname, Vorname = vorname, Tel = Convert.ToInt32(tel), WohnungsID = Convert.ToInt32(wohnungsID) });

            connection.Execute("dbo.Mieter_UpdateByMieterID @MieterID, @Nachname, @Vorname, @Tel, @WohnungsID", mieter);
        }
    }

    public List<Wohnung> GetWohnung(string hausID)
    {
        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FinnDB")))
        {
            var output = connection.Query<Wohnung>("dbo.Wohnungen_GetByHausID @HausID", new { HausID = hausID }).ToList();
            return output;
        }
    }

    public void InsertWohnung(string hausID, string stockwerk, string größe)
    {
        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FinnDB")))
        {
            List<Wohnung> lwohnungen = new List<Wohnung>();

            lwohnungen.Add(new Wohnung { HausID = Convert.ToInt32(hausID), Stockwerk = Convert.ToInt32(stockwerk), Größe = Convert.ToInt32(größe) });

            connection.Execute("dbo.Wohnungen_InsertWohnung @HausID, @Stockwerk, @Größe", lwohnungen);
        }
    }

    public void UpdateWohnung(string wohnungsID, string hausID, string stockwerk, string größe)
    {
        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FinnDB")))
        {
            List<Wohnung> wohnungen = new List<Wohnung>();

            wohnungen.Add(new Wohnung { WohnungsID = Convert.ToInt32(wohnungsID), HausID = Convert.ToInt32(hausID), Stockwerk = Convert.ToInt32(stockwerk), Größe = Convert.ToInt32(größe) });

            connection.Execute("dbo.Wohnungen_UpdateByWohnungsID @WohnungsID, @HausID, @Stockwerk, @Größe", wohnungen);
        }
    }


    public void DeletWohnung(object wohnungsID)
    {
        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FinnDB")))
        {
            List<Wohnung> wohnungen = new List<Wohnung>();

            wohnungen.Add(new Wohnung { WohnungsID = Convert.ToInt32(wohnungsID) });

            connection.Execute("dbo.Wohnungen_DeleteByWohnungsID @WohnungsID", wohnungen);
        }
    }
}