namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var transferMoneyTask = new TransferMoneyTask();

            transferMoneyTask.Execute();

            var generateReportTask = new GenerateReportTask();

            generateReportTask.Execute();
        }
    }
}
