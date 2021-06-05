using System;

namespace BusinessRuleEngine
{
    public class ActivateMembershipRule : MembershipRule
    {
        public override void Pay()
        {
            Console.WriteLine("Activating membership");
            SendMail();
        }
    }
}