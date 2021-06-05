using System;

namespace BusinessRuleEngine
{
    public abstract class ProductRule : PackingSlipRule 
    {
        public override void Pay()
        {
            Console.WriteLine("generating packing slip for shipment");
            GenerateAgentCommision();
        }
    }
}