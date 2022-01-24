using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactureApp.Model
{
  public  class Facture
    {
        [PrimaryKey, AutoIncrement]

        public int NumeroFacture { get; set; }
        public string Fournisseur { get; set; }
        public double TotalTTC { get; set; }
        public string ModePayement { get; set; }
        public DateTime Date { get; set; }
    }
}
