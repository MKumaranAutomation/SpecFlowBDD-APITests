Feature: APIStatusCode
	Get the API Status Code
	As a user
	I want to get the status code of ap

@mytag
Scenario: Get the Status Code 200 for the given api
	Given API End Point
	And pass the method as Get
	When I press send
	Then the Status Code should be OK/200  on API Response
