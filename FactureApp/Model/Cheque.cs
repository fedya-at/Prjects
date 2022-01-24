using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactureApp.Model
{
   public  class Cheque
    {
        [PrimaryKey,AutoIncrement]

        

        public string Banque { get; set; }
        public string Numero { get; set; }
        public DateTime Date { get; set; }
        public string Montant { get; set; }
    }
}
