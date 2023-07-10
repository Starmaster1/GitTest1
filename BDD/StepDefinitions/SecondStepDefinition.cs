using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD.StepDefinitions
{
    [Binding]
    public class SecondStepDefinition
    {
        protected ScenarioContext _ScenarioContext;
        public SecondStepDefinition(ScenarioContext scenarioContext)
        {
            _ScenarioContext = scenarioContext;
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            var numberOne = _ScenarioContext.Get<int>("NumberOne");
            var numberTwo = _ScenarioContext.Get<int>("NumberTwo");

            Assert.AreEqual(numberOne + numberTwo, result);
        }
    }
}
