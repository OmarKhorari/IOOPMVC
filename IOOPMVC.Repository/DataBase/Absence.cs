using System;
using System.Collections.Generic;

namespace IOOPMVC.Repository.DataBase
{
    public partial class Absence
    {
        public int IdAbsence { get; set; }
        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public string Justification { get; set; }
        public int? IdPersonne { get; set; }
    }
}
