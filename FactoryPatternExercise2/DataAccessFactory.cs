using System;
namespace FactoryPatternExercise2
{
	public class DataAccessFactory
	{
		internal static IDataAccess GetDataAccess()
		{
			Console.WriteLine($"What database would you like to use?");
			var answer = Console.ReadLine();


			switch(answer.ToLower())
			{
				case "list":
					return new ListDataAccess();

				case "sql":
					return new SQLDataAccess();

				case "mongo":
					return new MongoDataAccess();

				default:
					return new ListDataAccess();
			}
		}
    }
}

