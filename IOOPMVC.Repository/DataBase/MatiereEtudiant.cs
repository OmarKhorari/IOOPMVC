using System;
using System.Collections.Generic;

namespace IOOPMVC.Repository.DataBase
{
    public partial class MatiereEtudiant
    {
        public int IdCoursEtudiant { get; set; }
        public bool? Dispense { get; set; }
        public int? IdMatiere { get; set; }
        public int? IdEtudiant { get; set; }

        public virtual Etudiant IdEtudiantNavigation { get; set; }
        public virtual Matiere IdMatiereNavigation { get; set; }
    }
}
