using System;

namespace BusinessRuleEngine
{
    public class VideoOrderRule : RuleEngine 
    {
        public override void Pay()
        {
            Console.WriteLine("generating packing slip");
            AddFreeVideo();
        }

        public virtual void AddFreeVideo()
        {
            Console.WriteLine("adding free video to packing slip");
        }
    }
}