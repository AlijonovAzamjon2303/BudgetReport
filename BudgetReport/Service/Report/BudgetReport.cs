//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using BudgetReport.Service.Database;

namespace BudgetReport.Service.Report
{
    internal class BudgetReport : IReport
    {
        private IDatabase database;
        public BudgetReport()
        {
            this.database = new MySql();
        }
        public BudgetReport(IDatabase database)
        {
            this.database = database;
        }
        public List<string> Open(string date)
        {
            return this.database.Read();
        }

        public void Save(string data)
        {
            this.database.Insert(data);
        }
    }
}
