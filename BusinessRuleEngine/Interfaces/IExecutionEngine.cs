namespace BusinessRuleEngine
{
    public interface IExecutionEngine
    {

        public void SetRule(IRuleEngine rule);
        public void Execute();
    }
}
