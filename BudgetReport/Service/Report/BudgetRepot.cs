//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using BudgetReport.Service.Database;

namespace BudgetReport.Service.Report
{
    internal class BudgetRepot : IReport
    {
        private IDatabase database;
        public BudgetRepot()
        {
            this.database = new MySql();
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
