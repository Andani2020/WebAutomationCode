Feature: PrintGoogleHeadlines
	Go to http://news.google.com/ and print out all the headlines displayed on the page.

@mytag
Scenario: Navigate to google news and print headlines
    #steps
	Given I navigate to google news website
	And I read all the headlines and print
	Then close 