using System;
using System.Collections.Generic;

namespace IOOPMVC.Repository.DataBase
{
    public partial class Etudiant
    {
        public Etudiant()
        {
            MatiereEtudiant = new HashSet<MatiereEtudiant>();
        }

        public int IdEtudiant { get; set; }
        public string Matricule { get; set; }
        public string NomPère { get; set; }
        public string NomMère { get; set; }
        public string ProfessionPère { get; set; }
        public string ProfessionMère { get; set; }
        public string NiveauEtudePère { get; set; }
        public string NiveauEtudeMère { get; set; }
        public int IdPersonne { get; set; }
        public int IdAdresse { get; set; }
        public int IdFiliere { get; set; }

        public virtual Adresse IdAdresseNavigation { get; set; }
        public virtual Filiere IdFiliereNavigation { get; set; }
        public virtual Personne IdPersonneNavigation { get; set; }
        public virtual ICollection<MatiereEtudiant> MatiereEtudiant { get; set; }
    }
}
