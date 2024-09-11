Feature: Login


Scenario: Login to Top shop using valid credentials
	Given The user is navigated to the "https://www.topshop.com.mk/"
	When The user clicks the login button
	Then The "Најавете се" red button should appear 