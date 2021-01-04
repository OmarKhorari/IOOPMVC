using System;
using System.Collections.Generic;

namespace IOOPMVC.Repository.DataBase
{
    public partial class Cours
    {
        public int IdCours { get; set; }
        public DateTime? DateCours { get; set; }
        public string HeureCours { get; set; }
        public int? IdEmployee { get; set; }
        public int? IdClasse { get; set; }
        public int? IdMatiere { get; set; }
    }
}
