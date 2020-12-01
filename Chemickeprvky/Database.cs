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

		/// <summary>
        /// Create DB
        /// </summary>
        /// <param name="dbPath"> Set in FileHelper interface to enable cross platform</param>
		public Database(string dbPath)
		{
			database = new SQLiteAsyncConnection(dbPath);
			database.CreateTableAsync<Activ>().Wait();
		}

		/// <summary>
		/// Return all acitvated/deactivated results
		/// </summary>
		/// <returns> List<Active> </returns>
		public Task<List<Activ>> GetActives()
		{
			return database.QueryAsync<Activ>("SELECT * FROM Activ");
		}

		/// <summary>
		/// Return true if atomic number is active
		/// </summary>
		/// <param name="id">Atomic number of element</param>
		/// <returns>true if is active else false</returns>
		public bool GetIsActiv(int id)
		{
			var item = App.Database.GetItemAsync(id: id).Result;
			if (item == null)
			{
				return true;
			}
			return item.Active;
		}

		/// <summary>
		/// Return Activ result by given id
		/// </summary>
		/// <param name="id">Atomic number of element</param>
		/// <returns>Activ object</returns>
		public Task<Activ> GetItemAsync(int id)
		{
			return database.Table<Activ>().Where(i => i.AtomicNumber == id).FirstOrDefaultAsync();
		}

		/// <summary>
        /// Save or update given data 
        /// </summary>
        /// <param name="item">Activ object</param>
        /// <returns>Task</returns>
		public Task<int> SaveItemAsync(Activ item)
		{
			var exist = App.Database.GetItemAsync(id: item.AtomicNumber).Result;
			if (exist == null)
			{
				return database.InsertAsync(item);
			}
			return database.UpdateAsync(item);
			
		}

		/// <summary>
		/// Delete object by id
		/// </summary>
		/// <param name="id">Atomic number of element</param>
		/// <returns></returns>
		public Task<int> DeleteItemAsync(Activ item)
		{
			return database.DeleteAsync(item);
		}
	}
}
