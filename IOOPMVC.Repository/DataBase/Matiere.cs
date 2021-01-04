using System;
using System.Collections.Generic;

namespace IOOPMVC.Repository.DataBase
{
    public partial class Matiere
    {
        public Matiere()
        {
            MatiereEtudiant = new HashSet<MatiereEtudiant>();
        }

        public int IdMatiere { get; set; }
        public string CodeMatiere { get; set; }
        public string NomMatiere { get; set; }
        public int? IdModule { get; set; }

        public virtual Module IdModuleNavigation { get; set; }
        public virtual ICollection<MatiereEtudiant> MatiereEtudiant { get; set; }
    }
}
