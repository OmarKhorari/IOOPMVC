using System;
using System.Collections.Generic;

namespace IOOPMVC.Models
{
    public partial class EmployeeViewModel
    {
        public int IdEmployee { get; set; }
        public DateTime? DateEmbauce { get; set; }
        public string NiveauEtude { get; set; }
        public string DiplômeMax { get; set; }
        public int? Expérience { get; set; }
        public double? Salaire { get; set; }
        public DateTime? DateFinContrat { get; set; }
        public string Statut { get; set; }
        public int IdPersonne { get; set; }
        public int IdProfession { get; set; }
        public int IdAdresse { get; set; }
        public int? IdFiliere { get; set; }
    }
}
