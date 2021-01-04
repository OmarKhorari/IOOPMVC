using System;
using System.Collections.Generic;

namespace IOOPMVC.Models
{
    public partial class FiliereViewModel
    {
        public FiliereViewModel()
        {
            Etudiant = new HashSet<EtudiantViewModel>();
        }

        public int IdFiliere { get; set; }
        public string NomFiliere { get; set; }
        public string NiveauFiliere { get; set; }
        public string CapacitéFiliere { get; set; }
        public string DateQualification { get; set; }
        public string DureEnAnnée { get; set; }
        public int IdAdresse { get; set; }
        public int? IdEtablissement { get; set; }

        public virtual EtablissementViewModel IdEtablissementNavigation { get; set; }
        public virtual ICollection<EtudiantViewModel> Etudiant { get; set; }
    }
}
