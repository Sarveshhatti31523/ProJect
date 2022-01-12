Feature: Login

A short summary of the feature

@positive
Scenario: Successful registration
       Given User Launch Chrome Browser
       When User opens url  "http://practice.automationtesting.in/my-account/"
       And enters Email as "sarveshhattissbj@gmail.com" and password as "Sarvesh@4612"
       And click on register buttton
