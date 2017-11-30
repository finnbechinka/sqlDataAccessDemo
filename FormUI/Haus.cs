using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class Haus
    {
        public int HausID { get; set; }
        public string Bezeichnung { get; set; }
        public string Adresse { get; set; }
        public int HausmeisterTel { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{ HausID } { Bezeichnung } { Adresse } ({ HausmeisterTel })";
            }
        }

    }
}
