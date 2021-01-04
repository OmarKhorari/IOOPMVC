using System;
using System.Collections.Generic;

namespace IOOPMVC.Models
{
    public partial class AdresseViewModel
    {
        public AdresseViewModel()
        {
            Etablissement = new HashSet<EtablissementViewModel>();
            Etudiant = new HashSet<EtudiantViewModel>();
        }

        public int IdAdresse { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string Cp { get; set; }
        public string Ville { get; set; }
        public string Région { get; set; }
        public string Province { get; set; }
        public string Pays { get; set; }

        public virtual ICollection<EtablissementViewModel> Etablissement { get; set; }
        public virtual ICollection<EtudiantViewModel> Etudiant { get; set; }
    }
}
