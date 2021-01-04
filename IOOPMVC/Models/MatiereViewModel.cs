using System;
using System.Collections.Generic;

namespace IOOPMVC.Models
{ 
    public partial class MatiereViewModel
    {
        public MatiereViewModel()
        {
            MatiereEtudiant = new HashSet<MatiereEtudiantViewModel>();
        }

        public int IdMatiere { get; set; }
        public string CodeMatiere { get; set; }
        public string NomMatiere { get; set; }
        public int? IdModule { get; set; }

        public virtual ModuleViewModel IdModuleNavigation { get; set; }
        public virtual ICollection<MatiereEtudiantViewModel> MatiereEtudiant { get; set; }
    }
}
