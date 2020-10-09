Feature: Betway Register page

Go to https://www.betway.co.za and complete a full Registration form on the site.

@tag1
Scenario: complete a full Registration form on the site.
	
	Given I navigate to beatway home page
	Then  I click sign up page
	Then  I enter personal detail to register
	      | mobileNumber | password    | firstName | surname | email             |
	      | 08575325863  | password234 | Joe       | Cole    | joe.cole@gmai.com |  
	Then  I close the browser
