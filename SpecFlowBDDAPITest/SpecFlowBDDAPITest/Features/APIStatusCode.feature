Feature: APIStatusCode
	Get the API Status Code
	As a user 
	I want to validate the UserList api

@mytag
Scenario: Get the Status Code 200 for the given api
	Given API End Point 'https://reqres.in/api/users?page=2'
	And pass the method as Get
	When I press send
	Then the Status Code should be "OK" on API Response

Scenario: Get the Total Users from the API
	Given API End Point 'https://reqres.in/api/users?page=2'
	And pass the method as Get
	When I press send
	Then Verify that the Total Users should be 12