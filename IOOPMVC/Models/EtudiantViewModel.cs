using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IOOPMVC.Models
{
    public partial class EtudiantViewModel
    {
        public EtudiantViewModel()
        {
            matiereEtudiantViewModelsList = new HashSet<MatiereEtudiantViewModel>();
        }

        public int IdEtudiant { get; set; }
        [Required(ErrorMessage = "EtudiantFN")]
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

        public AdresseViewModel adresseViewModel { get; set; }
        public FiliereViewModel filiereViewModel { get; set; }
        public PersonneViewModel personneViewModel { get; set; }
        public ICollection<MatiereEtudiantViewModel> matiereEtudiantViewModelsList { get; set; }
    }
}
