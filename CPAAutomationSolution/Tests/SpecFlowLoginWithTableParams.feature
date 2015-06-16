Feature: SpecFlowLoginWithTableParams
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers


Scenario: Login Using Table Values
Given I have clicked the login button
And I have entered the <customerID> and <password>
| customerID | Password   |
| 10300149   | 01Password |
When I press login
Then the result should be a successful login

