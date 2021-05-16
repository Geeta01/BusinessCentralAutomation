Feature: Login
	Login to InnFlow

@smoke
Scenario: Perform Login of Innflow
	Given I launch the application
	And I enter the following details
		| UserName  | Password |
		| Admin.101 | test.123 | 

	And I click login button
	Then I should see the homepage

Scenario Outline: OutlineExample
#Given I landed application
When I fill all details in form  <Name>, <Age> and <Phone>
Examples:
| Name | Age | Phone |
| Vaanya  | 10 | 161515 |
| Reyansh | 3  | 75567  |
| Pihu    | 5  | 62772  |





