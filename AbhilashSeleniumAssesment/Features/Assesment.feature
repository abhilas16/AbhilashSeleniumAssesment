Feature: Assesment


Scenario: [Shopping scenario 1]
	Given I add four random item to my cart
	When I view my cart
	Then I find total four items listed in my cart
	When I search for lowest price item
	And I am able to remove lowest price item from my cart
	Then I am able to verify three items in my cart
