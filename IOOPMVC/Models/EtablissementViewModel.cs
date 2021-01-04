using System;
using System.Collections.Generic;

namespace IOOPMVC.Models
{
    public partial class EtablissementViewModel
    {
        public EtablissementViewModel()
        {
            Filiere = new HashSet<FiliereViewModel>();
        }

        public int IdEtablissement { get; set; }
        public string NomEtablissement { get; set; }
        public string Sigle { get; set; }
        public string NuméroAutorisation { get; set; }
        public string DateAutorisation { get; set; }
        public string AvisCommission { get; set; }
        public DateTime? DateAvis { get; set; }
        public string CadreRésponsable { get; set; }
        public int IdAdresse { get; set; }
        public int IdEmployee { get; set; }

        public virtual AdresseViewModel IdAdresseNavigation { get; set; }
        public virtual ICollection<FiliereViewModel> Filiere { get; set; }
    }
}
