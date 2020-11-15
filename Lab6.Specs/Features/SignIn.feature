Feature: Sign in
@SignIn
Scenario: Sign-up with success
	Given I have navigated to website
	And I click on sign-in button
	And I have entered Name in name field from sign-in pop-up
	And I have entered SuperSecre! in password field from sign-in pop-up
	When I press the sign-in button
	Then I should be loged in app