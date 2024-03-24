using BudgetReport.Service.Database;

internal class Program
{
    private static void Main(string[] args)
    {
        MySql mySql = new MySql();
        mySql.Delete(4);
    }
}