Feature: EAEAppTest



@smoke
Scenario: Test Login operation of EA Application
	Given I navigate to the application
	And I click login link
	And I enter following login details
		| UserName | Password |
		| admin    | password |
	Then I see employee lists