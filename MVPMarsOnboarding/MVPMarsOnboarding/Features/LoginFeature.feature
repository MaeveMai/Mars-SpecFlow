Feature: login steps
As a seller
I would like to login to the mars portal
So that I can manage profile successfully 

@Login
Scenario: Login to mars portal
    Given I login mars portal
	Then The profile page should be presented

