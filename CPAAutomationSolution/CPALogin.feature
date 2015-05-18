Feature: CPALogin
	In order to login to CPA website
	As a valid customer
	I want to confirm login successful

@mytag
Scenario: Log on to CPA Web Site
	Given I have clicked the login button
	And I have entered the customer id
	And I have entered the customer password
	When I press login
	Then the result should be a successful login
