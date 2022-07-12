Feature: Manage education module

As a seller
I would like to create, edit and delete education record in Profile page
So that I can manage profile successfully and people seeking for my info can look into my Profile


@Create
Scenario Outline: 1 create education record with details
	Given I logged into the Mars portal successfully 
	When I navigate to education Module
	And I add new education record with '<UniversityName>' and '<Degree>'
	Then the education record should be added successfully with correct '<UniversityName>' and '<Degree>'
	Examples: 
	| UniversityName           | Degree   |
	| University of Canterbury | Bachelor |
	| Massey University        | Master   |



@Edit
Scenario Outline: 2 edit education record with details
	Given I logged into the Mars portal successfully 
	When I navigate to education Module
	And I update '<UniversityName>' and '<Degree>' on existing education record
	Then the education record should have updated '<UniversityName>' and '<Degree>'
	Examples: 
	| UniversityName                    | Degree       |
	| Victoria University of Wellington | Postgraduate |
	| The University of Auckland        | Master       |



@Delete
Scenario: 3 delete existing education record
	Given I logged into the Mars portal successfully 
	When I navigate to education Module
	And I delete existing education record
	Then the education record should disappear from the education module