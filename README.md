# StringAPI

## Overview
StringAPI is a simple ASP.NET Core Web API that provides endpoints for string manipulation. It includes functionality to reverse a string and check if it is a palindrome.


## How Project Runs
1. Clone the project within Visual Studio
2. dotnet build
3. Press the start to build the project  (dotnet run project)
4. A page displaying StringAPI header
5. Click on the Get/api/client/string/{input} and it will drop-down
6. Click on the 'Try it out' so the input textbox can allow you to add informaton
7. Add a text example 'hello' then click on execute and response will be shown.
8. Then you have a choice to either clear the information or Execute again

## Dependencies
.NET SDK 8.0
Swagger for API Documentation

## Setup
git clone https://github.com/ofentse-sithole/StringAPI

## Usage
Reverse and Check Palindrome

Endpoint: /api/client/string/{input}
Method: GET

Request Example:
GET http://localhost:5001/api/client/string/hello
Accept: application/json

Response Example:
{
  "ReversedString": "olleh",
  "IsPalindrome": false
}



