Feature: Manage Certificate Module 

As a seller
I would like to create, edit and delete certification record in Profile page
So that I can manage profile successfully and people seeking for my info can look into my Profile

@Create
Scenario Outline: 1 create certification record with details
	Given I login to the Mars portal successfully 
	When I navigate to certification Module
	And I add new certification record with '<CertificationName>' and '<CertificatedFrom>'
	Then the certification record should be added successfully with correct '<CertificationName>' and '<CertificatedFrom>'

	Examples: 
	| CertificationName | CertificatedFrom   |
	| Best Programmer   | Industry Connect   |
	| Best lecturers    | Lincoln University |


@Edit
Scenario Outline: 2 edit certification record with details
	Given I login to the Mars portal successfully  
	When I navigate to certification Module
	And I update '<CertificationName>' and '<CertificatedFrom>' on existing certification record
	Then the certification record should have updated '<CertificationName>' and '<CertificatedFrom>' 
	Examples: 
	| CertificationName | CertificatedFrom         |
	| Best Tester       | MVP Studio               |
	| Best Tutors       | University of Canterbury |


@Delete
Scenario: 3 delete existing certification record
	Given I login to the Mars portal successfully  
	When I navigate to certification Module
	And I delete existing certification record
	Then the certification record should disappear from the certification module
