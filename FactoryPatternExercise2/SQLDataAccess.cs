using System;
namespace FactoryPatternExercise2
{
	public class SQLDataAccess : IDataAccess
	{
		public SQLDataAccess()
		{
		}

        public void LoadData()
        {
            Console.WriteLine($"I am reading data from {GetType().Name}.");
        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data from a {GetType().Name} database.");
        }
    }
}

