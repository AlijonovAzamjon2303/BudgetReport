//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

namespace BudgetReport.Service.Report
{
    internal interface IReport
    {
        List<string> Open(string date);
        void Save(string data);
    }
}
