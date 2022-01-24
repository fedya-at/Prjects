using FactureApp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FactureApp.IDAO
{
    interface IDatabase
    {
         Task<List<Facture>> GetFactureAsync();
        Task<int> SaveFactureAsync(Facture facture);

    }
}
