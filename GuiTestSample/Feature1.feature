Feature: Feature1

A short summary of the feature
Background:
Given table
	| comment      |
	| hello        |
	| Hello        |
	| Hellow World |
	| I messed up  |
	And table
	| side | answer |
	| 1    | 1      |
	| 2    | 4      |



@tag1
Scenario: commit a comment
	Given a user types (.*) in a comment
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

@tag4
Scenario Outline: Enters a comment
	Given a user enters a <comment>
	When the user clicks commit
	Then the answer is true

	Examples:
	| comment      |
	| hello        |


	@tag5
Scenario:  find parameter of a square
	Given a user enters <side>
	When the  user clicks find
	Then the  answer is <answer>


