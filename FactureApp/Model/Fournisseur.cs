using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactureApp.Model
{
   public  class Fournisseur
    {
        [PrimaryKey, AutoIncrement]

        public string CodeFournisseur { get; set; }
        public string NomFournisseur { get; set; }
        public string AdressFournisseur { get; set; }
    }
}
