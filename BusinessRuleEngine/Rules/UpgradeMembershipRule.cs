using System;

namespace BusinessRuleEngine
{
    public class UpgradeMembershipRule : MembershipRule
    {
        public override void Pay()
        {
            Console.WriteLine("upgrading membership");
            SendMail();
        }
    }
}