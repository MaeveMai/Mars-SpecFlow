Feature: Manage language module

As a seller
I would like to create, edit and delete Language record in Profile page
So that I can manage profile successfully and people seeking for my info can look into my Profile

@Create
Scenario Outline: 1 create language record with details
	Given I login to Mars portal successfully 
	When I navigate to language module
	And I add new '<language>' records on lauguange module
	Then the '<language>' records should be added in language module successfully

	Examples: 
	| language |
	| Mandarin |
	| Spanish  |


@Edit
Scenario Outline: 2 edit language record with details
	Given I login to Mars portal successfully 
	When I navigate to language module
	And I update '<Language>'on existing language record
	Then the language record should have updated '<Language>'

	Examples: 
	| Language |
	| French   |
	| Japanese |


@Delete
Scenario: 3 delete existing language record
	Given I login to Mars portal successfully 
	When I navigate to language module
	And I delete existing language record
	Then the language record should disappear from the language module