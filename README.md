# A Repo of Example C# Solutions

## Demonstrates

- Ability to use Git, GitHub, and Markdown
    - Creating atomic commits
    - Branching for new features (ie each project in this repo)
    - Submitting and accepting pull requests
    - Submitting and closing issues with PRs
- All solutions developed with Visual Studio 2019
- All other files (such as this README.md) are written using Visual Studio Code
- Documentation
    - External documentation with this README
    - Internal documentation with commenting within the project

## Projects

### TicTacToe

A basic console app for the game "Tic Tac Toe"

#### Demonstrates

- Basic C# concepts such as branching, looping, and data manipulation
- Basic OOP
- Unit testing
- Exceptions
- Getting user input from console, including sanitisation

#### Instructions

Input moves of the form "row col", where row and col are numbers between 0 and 2, where top left = 0 0 and bottom right = 2 2.

Moves alternate between 'x' and 'o', and 'x' begins.

### WeatherStats

An app that retrieves the last 72 hours of weather information for Perth from "www.bom.gov.au", and outputs statistics about the last 72 hours to a text file.

#### Demonstrates

- Using NuGet to install and use 3rd party libraries (Newtonsoft.Json)
- Make HTTP Get Requests from 3rd Party Websites
- Parse JSON Data
- File Creation and Writing
- Overriding default methods (ToString)
- Parse command line arguments

#### Instructions

By either the command line or by user input if no command line argument is given, enter a file path for where the output should be written of the form "path\to\file\file.txt"
