Feature: Search

A short summary of the feature


Scenario: Verify that the user is able to search for a kitchen object
	Given The user is navigated to the "https://www.topshop.com.mk/"
	When The user clicks the login button
	Then The "Најавете се" red button should appear 
	When The user clicks the "Најавете се" red button
	Then The Login page should appear
	When I enter the username as "denkovski112a@yahoo.com", password as "acecar" and click submit
	Then The user should be sucessfuly loged in and text "Здраво,  Aleksandar Damjanovski!" should be presented at the page
	When I click the kitchen button
	Then The kitchen page should be opened
	When I search for a "Electric pressure" using the search bar
	Then There should be item "DELIMANO ELECTRIC PRESSURE MULTICOOKER BLACK 5,7l" as result


	
