Feature: Manage profile details
As a seller
I would like to create, edit and delete Language, education, and certification record in Profile page
So that I can manage profile successfully and people seeking for my info can look into my Profile

@Login
Scenario: A Login to mars portal
    Given I login mars portal
	Then The profile page should be presented

@PersonalDetail
Scenario: B1 Add personal details
    Given I logged into Mars portal successfully
	When I input my first name and last name
	And  I click Availability, Hours, Earn Target and input Descriptioon
	Then The profile page details should be added

@PersonalDetail
Scenario: B2 Update personal details
    Given I logged into Mars portal successfully
	When I Update my first name and last name
	And  I update Availability, Hours, Earn Target and Descriptioon
	Then The profile page details should be updated

@PersonalDetail
Scenario: B3 Add personal details
    Given I logged into Mars portal successfully
	When I delete my first name and last name
	And  I delete Descriptioon
	Then The profile page details should be deleted

@Language
Scenario Outline: C1 create language record with details
	Given I logged into Mars portal successfully
	When I navigate to language module
	And I add new '<language>' records on lauguange module
	Then the '<language>' records should be added in language module successfully

	Examples: 
	| language |
	| Mandarin |
	| Spanish  |


@Language
Scenario Outline: C2 edit language record with details
	Given I logged into Mars portal successfully 
	When I navigate to language module
	And I update '<Language>'on existing language record
	Then the language record should have updated '<Language>'

	Examples: 
	| Language |
	| French   |
	| Japanese |


@Language
Scenario: C3 delete existing language record
	Given I logged into Mars portal successfully 
	When I navigate to language module
	And I delete existing language record
	Then the language record should disappear from the language module


@Education
Scenario Outline: D1 create education record with details
	Given I logged into Mars portal successfully 
	When I navigate to education Module
	And I add new education record with '<UniversityName>' and '<Degree>'
	Then the education record should be added successfully with correct '<UniversityName>' and '<Degree>'

	Examples: 
	| UniversityName           | Degree   |
	| University of Canterbury | Bachelor |
	| Massey University        | Master   |


@Education 
Scenario Outline: D2 edit education record with details
	Given I logged into Mars portal successfully 
	When I navigate to education Module
	And I update '<UniversityName>' and '<Degree>' on existing education record
	Then the education record should have updated '<UniversityName>' and '<Degree>'

	Examples: 
	| UniversityName                    | Degree       |
	| Victoria University of Wellington | Postgraduate |
	| The University of Auckland        | Master       |


@Education 
Scenario: D3 delete existing education record
	Given I logged into Mars portal successfully 
	When I navigate to education Module
	And I delete existing education record
	Then the education record should disappear from the education module


@Certifications 
Scenario Outline: E1 create certification record with details
	Given I logged into Mars portal successfully 
	When I navigate to certification Module
	And I add new certification record with '<CertificationName>' and '<CertificatedFrom>'
	Then the certification record should be added successfully with correct '<CertificationName>' and '<CertificatedFrom>'

	Examples: 
	| CertificationName | CertificatedFrom   |
	| Best Programmer   | Industry Connect   |
	| Best lecturers    | Lincoln University |


@Certifications 
Scenario Outline: E2 edit certification record with details
	Given I logged into Mars portal successfully 
	When I navigate to certification Module
	And I update '<CertificationName>' and '<CertificatedFrom>' on existing certification record
	Then the certification record should have updated '<CertificationName>' and '<CertificatedFrom>' 
	Examples: 
	| CertificationName | CertificatedFrom         |
	| Best Tester       | MVP Studio               |
	| Best Tutors       | University of Canterbury |


@Certifications 
Scenario: E3 delete existing certification record
	Given I logged into Mars portal successfully 
	When I navigate to certification Module
	And I delete existing certification record
	Then the certification record should disappear from the certification module


@Skill
Scenario Outline: F1 create skill record with details
	Given I logged into Mars portal successfully 
	When I navigate to skills Module
	And I add new '<skill>' record in skill module
	Then the '<skill>' record should be added successfully in skill module

	Examples: 
	| skill       |
	| Programming |
	| Writing     |

@Skill 
Scenario Outline: F2 edit skill record with details
	Given I logged into Mars portal successfully 
	When I navigate to skills Module
	And I update '<skill>'on existing skill record
	Then the skill record should have updated '<skill>'

	Examples: 
	| skill              |
	| Automation Testing |
	| Swimming           |

@Skill 
Scenario: F3 delete existing skill record
	Given I logged into Mars portal successfully 
	When I navigate to skills Module
	And I delete existing skill record
	Then the skill record should disappear from the skills module
