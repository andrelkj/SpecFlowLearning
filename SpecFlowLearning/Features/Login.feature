Feature: Login Feature
In order to perform successful login
As a User
I have to enter correct username and password

    Scenario Outline: Successful login with valid credentials
        Given I have navigated to the login page
        When I enter the "<username>" and "<password>"
        Then I should be redirected to the dashboard
        And select the city and country information
        | city  | country  |
        | city1 | country1 |
        | city2 | country2 |
        
        Examples: 
        | username | password |
        | user1    | 123456   |
        | user2    | 123456   |