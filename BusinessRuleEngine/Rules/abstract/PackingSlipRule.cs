using System;

namespace BusinessRuleEngine
{
    public abstract class PackingSlipRule : RuleEngine
    {
        public override void Pay()
        {
            Console.WriteLine("generating packing slip...");
        }

        public virtual void GenerateAgentCommision()
        {
            Console.WriteLine("generating agent commision...");
        }
    }
}