using System;

namespace TemplateMethod
{
    public class GenerateReportTask : Task
    {
        protected override void DoExecute()
        {
            Console.WriteLine("Generating Report ...");
        }
    }
}