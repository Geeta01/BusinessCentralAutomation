Feature: BCLogin
	Simple calculator for adding two numbers

@mytag
Scenario: Login to BC
	Given I launch the BC application
	And I click on Sign in button
	And I enter the UserName '27255@davfbd14.onmicrosoft.com'
	And I enter the Password 'angel@2402'	

	Then I should see the BC homepage