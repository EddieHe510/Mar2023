﻿Feature: TMFeature

As a Turnup portal admin
I would like to create, edit time and material records
So that I can manage emplyees time and materials successfully

@tag1
Scenario: Create time and material record with valid details
	Given I logged into turn portal successfully
	When I navigate to Time and Material page
	And I create a new time and material record
	Then The record should be created successfully
