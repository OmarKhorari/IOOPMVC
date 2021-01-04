using System;
using System.Collections.Generic;

namespace IOOPMVC.Repository.DataBase
{
    public partial class Adresse
    {
        public Adresse()
        {
            Etablissement = new HashSet<Etablissement>();
            Etudiant = new HashSet<Etudiant>();
        }

        public int IdAdresse { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string Cp { get; set; }
        public string Ville { get; set; }
        public string Région { get; set; }
        public string Province { get; set; }
        public string Pays { get; set; }

        public virtual ICollection<Etablissement> Etablissement { get; set; }
        public virtual ICollection<Etudiant> Etudiant { get; set; }
    }
}
