using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chemickeprvky
{
	public class Database
	{
		private SQLiteAsyncConnection database;

		public Database(string dbPath)
		{
			database = new SQLiteAsyncConnection(dbPath);
			database.CreateTableAsync<Activ>().Wait();
		}


        public Task<List<Activ>> GetItemsAsync()
		{
			return database.Table<Activ>().ToListAsync();
		}

		public Task<List<Activ>> GetItemsNotDoneAsync()
		{
			return database.QueryAsync<Activ>("SELECT * FROM Activ WHERE name ='Activ' and type='table'");
		}

		public bool GetActiv(int id)
		{
			foreach (Activ x in database.QueryAsync<Activ>(string.Format("SELECT activ FROM Activ WHERE AtomicNumber='{0}'", id)).Result) {
				return x.Active;
			}
			return true;

		}

		public Task<Activ> GetItemAsync(int id)
		{
			return database.Table<Activ>().Where(i => i.AtomicNumber == id).FirstOrDefaultAsync();
		}


		public Task<int> SaveItemAsync(Activ item)
		{
			if (item.AtomicNumber != 0)
			{
				return database.UpdateAsync(item);
			}
			else
			{
				return database.InsertAsync(item);
			}
		}

		public Task<int> DeleteItemAsync(Activ item)
		{
			return database.DeleteAsync(item);
		}
	}
}
