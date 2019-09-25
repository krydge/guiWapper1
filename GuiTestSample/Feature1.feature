Feature: Feature1

A short summary of the feature


@tag1
Scenario: commit a comment
	Given a user types "this" in a comment
	When the user clicks commit
	Then the answer is true

@tag2
Scenario: click Dark Mode
	Given a user is in light mode
	When the user clicks dark mode
	Then the background changes to dark

@tag3
Scenario: click Light Mode
	Given a user is in dark mode
	When the user clicks light mode
	Then the background changes to light
