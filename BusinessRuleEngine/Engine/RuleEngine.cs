using BusinessRuleModels;

namespace BusinessRuleEngine
{
    public abstract class RuleEngine : IRuleEngine
    {
        public RuleModel Model { get; set; }
        public abstract void Pay();
        public virtual void SetModel(RuleModel model)
        {
            Model = model;
        }
    }
}