using System;
using System.Collections.Generic;

namespace IOOPMVC.Repository.DataBase
{
    public partial class Filiere
    {
        public Filiere()
        {
            Etudiant = new HashSet<Etudiant>();
        }

        public int IdFiliere { get; set; }
        public string NomFiliere { get; set; }
        public string NiveauFiliere { get; set; }
        public string CapacitéFiliere { get; set; }
        public string DateQualification { get; set; }
        public string DureEnAnnée { get; set; }
        public int IdAdresse { get; set; }
        public int? IdEtablissement { get; set; }

        public virtual Etablissement IdEtablissementNavigation { get; set; }
        public virtual ICollection<Etudiant> Etudiant { get; set; }
    }
}
