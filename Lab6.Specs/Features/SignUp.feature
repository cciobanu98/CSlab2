Feature: Sign up
@SignUp
Scenario: Sign-up with success
	Given I have navigated to website
	And I click on sign-up button
	And I have entered Name in name field
	And I have entered cristian@gmail.com in email field
	And I have entered SuperSecret! in password field
	And I have entered SuperSecret! in confirm password field
	When I press the sign-up button
	Then I should be loged in app

@SignUp
Scenario: Sign-up with diiferent passwords
	Given I have navigated to website
	And I click on sign-up button
	And I have entered Name in name field
	And I have entered cristian@gmail.com in email field
	And I have entered SuperSecret! in password field
	And I have entered WrongPasword! in confirm password field
	When I press the sign-up button
	Then I should see error pop-up: 'Different passwords'
