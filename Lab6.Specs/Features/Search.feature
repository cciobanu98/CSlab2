Feature: Search
@mytag
Scenario: Perform search with empty data
	Given I have navigated to website
	When I press the search button
	Then Error popup should apear