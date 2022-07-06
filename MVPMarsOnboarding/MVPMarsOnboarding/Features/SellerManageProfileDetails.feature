Feature: SellerManageProfileDetails
As a seller
I would like to create, edit and delete Profile Details including language, skills, education and certifications
So that I can manage seller's Profile Detail successfully and people seeking for some skills can look into my details.

@Login
Scenario: 1 Login to mars portal
    Given I Open mars portal
	When I input correct credential
	Then The profile page should be presented

@Language
Scenario Outline: 2 create language record with details
	Given I logged into Mars portal successfully
	When I add new '<language>' records on lauguange module
	Then the '<language>' records should be added in language module successfully

	Examples: 
	| language |
	| Mandarin |
	| Spanish  |


@Language
Scenario Outline: 3 edit language record with details
	Given I logged into Mars portal successfully 
	When I update '<Language>'on existing language record
	Then the language record should have updated '<Language>'

	Examples: 
	| Language |
	| French   |
	| Japanese |


@Language
Scenario: 4 delete existing language record
	Given I logged into Mars portal successfully 
	When I delete existing language record
	Then the language record should disappear from the language module

@Skill
Scenario Outline: create skill record with details
	Given I logged into Mars portal successfully 
	When I navigate to skills Module
	And I add new '<skill>' record
	Then the '<skill>' record should be added successfully

	Examples: 
	| skill       |
	| Programming |
	| Writing     |

@Skill 
Scenario Outline: edit skill record with details
	Given I logged into Mars portal successfully 
	When I navigate to skills Module
	And I update '<skill>'on existing skill record
	Then the skill record should have updated '<skill>'

	Examples: 
	| skill              |
	| Automation Testing |
	| Swimming           |

@Skill 
Scenario: delete existing skill record
	Given I logged into Mars portal successfully 
	When I navigate to skills Module
	And I delete existing skill record
	Then the skill record should disappear from the skills module

@Education
Scenario Outline: create education record with details
	Given I logged into Mars portal successfully 
	When I navigate to education Module
	And I add new education record with '<University Name>' and '<Degree>'
	Then the education record should be added successfully with correct '<University Name>' and '<Degree>'

	Examples: 
	| University Name          | Degree            |
	| University of Canterbury | Bachelor's Degree |
	| Massey University        | Master's degree   |

@Education 
Scenario Outline: edit education record with details
	Given I logged into Mars portal successfully 
	When I navigate to education Module
	And I update '<University Name>' and '<Degree>' on existing education record
	Then the education record should have updated '<University Name>' and '<Degree>'

	Examples: 
	| University Name                   | Degree              |
	| Victoria University of Wellington | Postgraduate degree |
	| The University of Auckland        | Master's degree     |

@Education 
Scenario: delete existing education record
	Given I logged into Mars portal successfully 
	When I navigate to education Module
	And I delete existing education record
	Then the education record should disappear from the education module

@Certifications 
Scenario Outline: create certification record with details
	Given I logged into Mars portal successfully 
	When I navigate to certification Module
	And I add new certification record with '<Certification Name>' and '<Certificated From>'
	Then the certification record should be added successfully with correct '<Certification Name>' and '<Certificated From>'

	Examples: 
	| Certification Name | Certificated From  |
	| Best Programmer    | Industry Connect   |
	| Best lecturers     | Lincoln University |

@Certifications 
Scenario Outline: edit certification record with details
	Given I logged into Mars portal successfully 
	When I navigate to certification Module
	And I update '<Certification Name>' and '<Certificated From>' on existing certification record
	Then the certification record should have updated '<Certification Name>' and '<Certificated From>' 
	Examples: 
	| Certification Name | Certificated From        |
	| Best Tester        | MVP Studio               |
	| Best Tutors        | University of Canterbury |

@Certifications 
Scenario: delete existing certification record
	Given I logged into Mars portal successfully 
	When I navigate to certification Module
	And I delete existing certification record
	Then the certification record should disappear from the certification module