using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace FormUI
{
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

        internal void InsertHaus(string bezeichnung, string adresse, string hausmeisterTel)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FinnDB")))
            {
                ///Haus newHaus = new Haus { Bezeichnung = bezeichnung, Adresse = adresse, HausmeisterTel = hausmeisterTel };
                List<Haus> häuser = new List<Haus>();

                häuser.Add(new Haus { Bezeichnung = bezeichnung, Adresse = adresse, HausmeisterTel = Convert.ToInt32(hausmeisterTel) });

                connection.Execute("dbo.Häuser_InsertHaus @Bezeichnung, @Adresse, @HausmeisterTel", häuser);
            }
        }

        internal void UpdateHaus(string hausID, string bezeichnung, string adresse, string hausmeisterTel)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FinnDB")))
            {
                List<Haus> häuser = new List<Haus>();

                häuser.Add(new Haus { HausID = Convert.ToInt32(hausID), Bezeichnung = bezeichnung, Adresse = adresse, HausmeisterTel = Convert.ToInt32(hausmeisterTel) });

                connection.Execute("dbo.Häuser_UpdateByHausID @HausID, @Bezeichnung, @Adresse, @HausmeisterTel",häuser);
            }
        }

        internal void DeleteHaus(string hausID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FinnDB")))
            {
                List<Haus> häuser = new List<Haus>();

                häuser.Add(new Haus { HausID = Convert.ToInt32(hausID) });
               
                connection.Execute("dbo.Häuser_DeleteByHausID @HausID", häuser);
            }
        }
        
        public List<Mieter> GetMieter(string nachname)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FinnDB")))
            {
                var output = connection.Query<Mieter>("dbo.Mieter_GetByNachname @Nachname", new { Nachname = nachname }).ToList();
                return output;
            }
        }

        internal void InsertMieter(string nachname, string vorname, string tel, string wohnungsID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FinnDB")))
            {
                List<Mieter> mieter = new List<Mieter>();

                mieter.Add(new Mieter { Nachname = nachname, Vorname = vorname, Tel = Convert.ToInt32(tel), WohnungsID = Convert.ToInt32(wohnungsID) });

                connection.Execute("dbo.Mieter_InsertMieter @Nachname, @Vorname, @Tel, @WohnungsID", mieter);
            }
        }

        internal void DeleteMieter(string mieterID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FinnDB")))
            {
                List<Mieter> mieter = new List<Mieter>();

                mieter.Add(new Mieter { MieterID = Convert.ToInt32(mieterID) });

                connection.Execute("dbo.Mieter_DeleteByMieterID @MieterID", mieter);
            }
        }

        internal void UpdateMieter(string mieterID, string nachname, string vorname, string tel, string wohnungsID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FinnDB")))
            {
                List<Mieter> mieter = new List<Mieter>();

                mieter.Add(new Mieter { MieterID = Convert.ToInt32(mieterID), Nachname = nachname, Vorname = vorname, Tel = Convert.ToInt32(tel), WohnungsID = Convert.ToInt32(wohnungsID) });

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

        internal void InsertWohnung(string hausID, string stockwerk, string größe)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FinnDB")))
            {
                List<Wohnung> wohnungen = new List<Wohnung>();

                wohnungen.Add(new Wohnung { HausID = Convert.ToInt32(hausID), Stockwerk = Convert.ToInt32(stockwerk), Größe = Convert.ToInt32(größe)});

                connection.Execute("dbo.Wohnungen_InsertWohnung @HausID, @Stockwerk, @Größe", wohnungen);
            }
        }

        internal void UpdateWohnung(string wohnungsID, string hausID, string stockwerk, string größe)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FinnDB")))
            {
                List<Wohnung> wohnungen = new List<Wohnung>();

                wohnungen.Add(new Wohnung { WohnungsID = Convert.ToInt32(wohnungsID), HausID = Convert.ToInt32(hausID), Stockwerk = Convert.ToInt32(stockwerk), Größe = Convert.ToInt32(größe) });

                connection.Execute("dbo.Wohnungen_UpdateByWohnungsID @WohnungsID, @HausID, @Stockwerk, @Größe", wohnungen);
            }
        }


        internal void DeletWohnung(object wohnungsID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FinnDB")))
            {
                List<Wohnung> wohnungen = new List<Wohnung>();

                wohnungen.Add(new Wohnung { WohnungsID = Convert.ToInt32(wohnungsID) });

                connection.Execute("dbo.Wohnungen_DeleteByWohnungsID @WohnungsID", wohnungen);
            }
        }
    }
}
