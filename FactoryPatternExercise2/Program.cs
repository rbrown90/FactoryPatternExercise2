namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            IDataAccess myDatabase = DataAccessFactory.GetDataAccess();

            myDatabase.LoadData();

            myDatabase.SaveData();


        }
    }
}
