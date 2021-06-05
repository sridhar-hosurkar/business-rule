using System;

namespace BusinessRuleEngine
{
    public abstract class MembershipRule : RuleEngine
    {
        public override void Pay()
        {
            Console.WriteLine("activation/upgrade membership");
        }

        protected virtual void SendMail()
        {
            Console.WriteLine("sending mail ...");
        }
    }
}