namespace BusinessRuleEngine
{
    public class ExecutionEngine : IExecutionEngine
    {
        IRuleEngine Rule;

        public void SetRule(IRuleEngine rule)
        {
            Rule = rule;
        }

        public void Execute()
        {
            Rule.Pay();
        }
    }
}
