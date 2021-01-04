using System;
using System.Collections.Generic;

namespace IOOPMVC.Repository.DataBase
{
    public partial class Notes
    {
        public int IdNote { get; set; }
        public double? Note { get; set; }
        public int? IdEtudiant { get; set; }
        public int? IdMatiere { get; set; }
        public int? IdAnneeScolaire { get; set; }
    }
}
