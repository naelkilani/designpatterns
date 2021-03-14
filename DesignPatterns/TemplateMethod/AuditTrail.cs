using System;

namespace TemplateMethod
{
    public class AuditTrail
    {
        public void Record()
        {
            Console.WriteLine("Audit");
        }
    }

    public abstract class Task
    {
        private readonly AuditTrail _auditTrail;

        protected Task()
        {
            _auditTrail = new AuditTrail();
        }

        protected Task(AuditTrail auditTrail)
        {
            _auditTrail = new AuditTrail();
        }

        public void Execute()
        {
            _auditTrail.Record();

            DoExecute();
        }

        protected abstract void DoExecute();
    }
}