Feature: Search
@Search
Scenario: Perform search with empty data
	Given I have navigated to website
	When I press the search button
	Then Error popup should apear

@Search
Scenario: Perform search with valid data
	Given I have navigated to website
	And I have entered Product as a search keyword
	When I press the search button
	Then I should navigate to search result page