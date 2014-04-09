Feature: Tic Tac Toe
	In order to determine who the winner of the game as
	As a Player
	I want to be told who (if anyone) won the game

Scenario: Empty board ends with a tie
	Given I have a tic tac toe board
	And the board is empty
	When I determine the winner
	Then the result of " "

Scenario: When X is across the top row then X is the winner
	Given I have a tic tac toe board
	And I have all "X" in the top row
	When I determine the winner
	Then the result of "X"

Scenario: When O is across the top row then O is the winner
	Given I have a tic tac toe board
	And I have all "O" in the top row
	When I determine the winner
	Then the result of "O"

Scenario: I have X in upper left and lower righ, user puts X in middle and wins
	Given I have a tic tac toe board
	And It looks like this
		| col1 | col2 | col3 |
		| X    |      |      |
		|      |      |      |
		|      |      | X    |
	When I determine the winner
	Then the result of "X"