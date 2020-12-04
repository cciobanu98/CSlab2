Feature: Variant1
@Homepage
Scenario: Check page 
	Given User navigated to https://www.google.com
	Then The google page is shown

@Results
Scenario: Check how many results are on page
	Given User navigated to https://www.google.com
	When User fill the search input with SpecFlow
	And User press the search button
	Then Count results on page

@Nothing
Scenario: Search nothing
	Given User navigated to https://www.google.com
	When User leave the search input empty
	And User press the search button
	Then The google page is shown

@SearchIrrelevant
Scenario: Irrelevant search
	Given User navigated to https://www.google.com
	When User fill the search input with SpecFlo
	And User press the search button
	Then Do you mean link is present