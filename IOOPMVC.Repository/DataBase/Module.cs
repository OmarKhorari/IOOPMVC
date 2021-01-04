using System;
using System.Collections.Generic;

namespace IOOPMVC.Repository.DataBase
{
    public partial class Module
    {
        public Module()
        {
            Matiere = new HashSet<Matiere>();
        }

        public int IdModule { get; set; }
        public string NomModule { get; set; }

        public virtual ICollection<Matiere> Matiere { get; set; }
    }
}
