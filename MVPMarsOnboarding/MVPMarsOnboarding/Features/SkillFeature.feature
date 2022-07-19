Feature: Manage skill module

As a seller
I would like to create, edit and delete skill record in Profile page
So that I can manage profile successfully and people seeking for my info can look into my Profile

@Create
Scenario Outline: 1 create skill record with details
	Given I login to the Mars portal successfully 
	When I navigate to skills Module
	And I add new '<skill>' record in skill module
	Then the '<skill>' record should be added successfully in skill module
	Examples: 
	| skill       |
	| Programming |
	| Writing     |


@Edit
Scenario Outline: 2 edit skill record with details
	Given I login to the Mars portal successfully  
	When I navigate to skills Module
	And I update '<skill>'on existing skill record
	Then the skill record should have updated '<skill>'
	Examples: 
	| skill              |
	| Automation Testing |
	| Swimming           |


@Delete
Scenario: 3 delete existing skill record
	Given I login to the Mars portal successfully 
	When I navigate to skills Module
	And I delete existing skill record
	Then the skill record should disappear from the skills module

