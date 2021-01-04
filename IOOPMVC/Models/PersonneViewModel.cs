using System;
using System.Collections.Generic;

namespace IOOPMVC.Models
{
    public partial class PersonneViewModel
    {
        public PersonneViewModel()
        {
            Etudiant = new HashSet<EtudiantViewModel>();
        }

        public int IdPersonne { get; set; }
        public string Nom { get; set; }
        public string Prénom { get; set; }
        public DateTime? DateNaissance { get; set; }
        public int? Age { get; set; }
        public string Sexe { get; set; }
        public string Cin { get; set; }
        public string Nationalité { get; set; }
        public string Email { get; set; }
        public string Téléphone { get; set; }
        public string Gsm { get; set; }
        public string Fax { get; set; }

        public virtual ICollection<EtudiantViewModel> Etudiant { get; set; }
    }
}
