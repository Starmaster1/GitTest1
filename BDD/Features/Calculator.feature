Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](BDD/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**


@mytag
Scenario: Add two numbers
	* the second number is 70
	When the two numbers are added
	Then the result should be 120
	
@mytag
Scenario Outline: Add two numbers1
	Given the first number is <FirstNumber>
	* the second number is <SecondNumber>
	When the two numbers are added
	Then the result should be <Result>

Examples:
	| FirstNumber | SecondNumber | Result |
	| 70          | 50           | 120    |
	| 70          | 60           | 130    |

Scenario Outline: Table
	Given the following users exist:
		| name | email          |
		| Alex | alex@gmail.com |
		| Kate | kate@gmail.com |