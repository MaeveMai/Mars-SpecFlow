Feature: Manage personal detail feature

As a seller
I would like to Choose and change my personal detail in Profile page
So that I can manage profile successfully and people seeking for my info can look into my Profile

@PersonalDetail
Scenario: 1 Add personal details
    Given I log into Mars portal successfully
	When I input my first name and last name
	And  I click Availability, Hours, Earn Target and input Descriptioon
	Then The profile page details should be added

@PersonalDetail
Scenario: 2 Update personal details
    Given I log into Mars portal successfully
	When I Update my first name and last name
	And  I update Availability, Hours, Earn Target and Descriptioon
	Then The profile page details should be updated

@PersonalDetail
Scenario: 3 Add personal details
    Given I log into Mars portal successfully
	When I delete my first name and last name
	And  I delete Descriptioon
	Then The profile page details should be deleted




