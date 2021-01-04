using System;
using System.Collections.Generic;

namespace IOOPMVC.Models
{
    public partial class NotesViewModel
    {
        public int IdNote { get; set; }
        public double? Note { get; set; }
        public int? IdEtudiant { get; set; }
        public int? IdMatiere { get; set; }
        public int? IdAnneeScolaire { get; set; }
    }
}
