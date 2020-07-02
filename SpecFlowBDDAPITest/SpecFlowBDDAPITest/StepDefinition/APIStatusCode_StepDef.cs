namespace SpecFlowBDDAPITest.StepDefinition
{
    using Newtonsoft.Json;
    using NUnit.Framework;
    using RestSharp;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using TechTalk.SpecFlow;


	[Binding]
	public sealed class APIStatusCode_StepDef
	{

        private IRestResponse response;
        private ValidateResponse json_res;
        private RestClient client;
        private RestRequest request;


        [Given(@"API End Point '(.*)'")]
        public void GivenAPIEndPoint(string apiEndPoint)
        {
            client = new RestClient(apiEndPoint);
        }

        [Given(@"pass the method as Get")]
        public void GivenPassTheMethodAsGet()
        {
            request = new RestRequest(Method.GET);
        }

        [When(@"I press send")]
        public void WhenIPressSend()
        {
            response = client.Execute(request);
            json_res = JsonConvert.DeserializeObject<ValidateResponse>(response.Content);
        }

        [Then(@"the Status Code should be ""(.*)"" on API Response")]
        public void ThenTheStatusCodeShouldBeOnAPIResponse(string statusCode)
        {
            Assert.AreEqual(statusCode,response.StatusDescription);
        }

        [Then(@"Verify that the Total Users should be (.*)")]
        public void ThenVerifyThatTheTotalUsersShouldBe(int totalCount)
        {
            Assert.AreEqual(totalCount, json_res.Total);
        }

    }
}
