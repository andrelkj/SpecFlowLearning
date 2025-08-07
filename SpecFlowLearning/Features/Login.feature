Feature: Login Feature
In order to perform successful login
As a User
I have to enter correct username and password

    Scenario: Successful login with valid credentials
        Given I have navigated to the login page
        When I enter the username and password
        Then I should be redirected to the dashboard