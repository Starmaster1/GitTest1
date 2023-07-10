using NUnit.Framework;

namespace BDD.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        protected ScenarioContext _ScenarioContext; 
        public CalculatorStepDefinitions(ScenarioContext scenarioContext) 
        {
        _ScenarioContext = scenarioContext;
        }


        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _ScenarioContext["NumberOne"] = number;
            Console.WriteLine(number);
        }
        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _ScenarioContext["NumberTwo"] = number;
            Console.WriteLine(number);
        }

            [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            Console.WriteLine("Added numbers!");
        }


        [Given(@"the following users exist:")]
        public void GivenTheFollowingUsersExist(Table table)
        {
            throw new PendingStepException();
        }

    }
}