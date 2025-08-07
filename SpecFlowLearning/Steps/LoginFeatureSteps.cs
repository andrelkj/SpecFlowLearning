using System;
using Reqnroll;

namespace SpecFlowLearning.Steps
{
    [Binding]
    public class LoginFeatureSteps
    {
        [Given("I have navigated to the login page")]
        public void GivenIHaveNavigatedToTheLoginPage()
        {
            Console.WriteLine($"Navigation to login page");
        }

        [When("I enter the username and password")]
        public void WhenIEnterTheUsernameAndPassword()
        {
            Console.WriteLine($"Input valid user credentials");
        }

        [Then("I should be redirected to the dashboard")]
        public void ThenIShouldBeRedirectedToTheDashboard()
        {
            Console.WriteLine($"Redirected to dashboard");
        }
    }
}