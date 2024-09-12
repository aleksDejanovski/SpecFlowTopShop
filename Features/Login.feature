Feature: Login


Scenario: Verify that the login button is clickcable
	Given The user is navigated to the "https://www.topshop.com.mk/"
	When The user clicks the login button
	Then The "Најавете се" red button should appear 


Scenario: Login to Top shop using valid credentials
	Given The user is navigated to the "https://www.topshop.com.mk/"
	When The user clicks the login button
	Then The "Најавете се" red button should appear 
	When The user clicks the "Најавете се" red button
	Then The Login page should appear
	When I enter the username as "denkovski112a@yahoo.com", password as "acecar" and click submit
	Then The user should be sucessfuly loged in and text "Здраво,  Aleksandar Damjanovski!" should be presented at the page
