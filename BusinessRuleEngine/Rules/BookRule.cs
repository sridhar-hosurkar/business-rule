using System;

namespace BusinessRuleEngine
{
    public class BookRule : PackingSlipRule
    {
        public override void Pay()
        {
            Console.WriteLine("generating duplicate packing slip for royalty department");
            GenerateAgentCommision();
        }
    }
}