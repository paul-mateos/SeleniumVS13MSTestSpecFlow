Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Login to CPA Website
	Given I have clicked the login button
	And I have entered the customer id
	And I have entered the customer password
	When I press login
	Then the result should be a successful login
