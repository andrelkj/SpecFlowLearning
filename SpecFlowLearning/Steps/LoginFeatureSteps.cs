using System;
using System.Linq;
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

        [When("I enter the (.*) and (.*)")]
        public void WhenIEnterTheUsernameAndPassword(string name, string password)
        {
            Console.WriteLine($"Username: {name}, Password: {password}");
            Console.WriteLine($"Input valid user credentials");
        }

        [Then("I should be redirected to the dashboard")]
        public void ThenIShouldBeRedirectedToTheDashboard()
        {
            Console.WriteLine($"Redirected to dashboard");
        }

        [Then("select the city and country information")]
        public void ThenSelectTheCityAndCountryInformation(Table table)
        {
            // 1st approach - looping over the elements
            // This method will print all values within the same test case run
            /*foreach (var row in table.Rows)
            {
                var city = row["city"];
                var country = row["country"];

                Console.WriteLine($"City: {city}, Country: {country}");
                Console.WriteLine("------------------------------------");
            }*/

            // 2nd approach - row wise iteration
            // This method will print only the specified row values
            var data = table.Rows[1].ToDictionary(row => row.Key, row => row.Value);
            var city = data["city"];
            var country = data["country"];

            Console.WriteLine($"City: {city}, Country: {country}");
            Console.WriteLine("------------------------------------");
        }
    }
}