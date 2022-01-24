using FactureApp.IDAO;
using FactureApp.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FactureApp.DAO
{
  public   class Database : IDatabase
    {
        private readonly SQLiteAsyncConnection _database;
        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync < Facture > ();
        }
        public Task<List<Facture>> GetFactureAsync() => _database.Table<Facture>().ToListAsync();

        public Task<int> SaveFactureAsync(Facture facture) => _database.InsertAsync(facture);
    }
}
