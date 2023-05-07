using System;
namespace FactoryPatternExercise2
{
	public class ListDataAccess : IDataAccess
	{
		public ListDataAccess()
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

