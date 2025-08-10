Feature: Login Production Feature
In order to perform successful login on Production
As a User
I have to enter correct username and password

    @prod
    Scenario: Login to the production website
        Given user navigates to facebook website
        When user validates the homepage title
        And I enter the username and password
        And click the submit button
        Then user should log in