using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowBDDAPITest.StepDefinition
{
	[Binding]
	public sealed class APIStatusCode_StepDef
	{
		// For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

		private readonly ScenarioContext context;

		public APIStatusCode_StepDef(ScenarioContext injectedContext)
		{
			context = injectedContext;
		}

        [Given(@"API End Point")]
        public void GivenAPIEndPoint()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"pass the method as Get")]
        public void GivenPassTheMethodAsGet()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I press send")]
        public void WhenIPressSend()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the Status Code should be OK/(.*)  on API Response")]
        public void ThenTheStatusCodeShouldBeOKOnAPIResponse(int p0)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
