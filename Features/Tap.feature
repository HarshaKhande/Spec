Feature: Tap a element

A short summary of the feature

@Smoke
Scenario: Verify tapping of a element
	Given Launch the application
	When User taps on the views element
	Then User is naviagted to views page



@Smoke
Scenario: Verify Checkboxes and RadioButtons
	Given Launch the application
	When User taps on the views element
	And  User taps on the radio group  element
	Then User clicks on the radio button
	


