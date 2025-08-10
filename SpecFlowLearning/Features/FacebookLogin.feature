@staging
Feature: Facebook Login Functionality
    
    Scenario: Perform successful login
        Given a user navigates to the login page
        When user enters valid credentials
        Then user should log in successfully