Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

	@Test
	Scenario: travel scenario
	Given I entered the following data into the new travel form:
	| Field         | Value |
	| destinations  | bali                |
	| departureDate |  30 august 2022     |
	| returnDate    |  30 august 2022     |
    | ages          |  30                 |


	
