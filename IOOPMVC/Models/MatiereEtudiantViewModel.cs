using System;
using System.Collections.Generic;

namespace IOOPMVC.Models
{
    public partial class MatiereEtudiantViewModel
    {
        public int IdCoursEtudiant { get; set; }
        public bool? Dispense { get; set; }
        public int? IdMatiere { get; set; }
        public int? IdEtudiant { get; set; }

        public virtual EtudiantViewModel IdEtudiantNavigation { get; set; }
        public virtual MatiereViewModel IdMatiereNavigation { get; set; }
    }
}
