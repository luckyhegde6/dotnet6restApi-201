# dotnet6restApi-201

Industry Level REST API using .NET 6 - Hands on ref -<https://www.youtube.com/watch?v=PmDJIooZjBE>

# To Start with Initialization

## Starting with Creating Solution

Run below command
`dotnet new sln -o breakfastRestApi` to create a new solution
then `cd breakfastRestApi`
Create the Projects:

- `dotnet new classlib -o breakfastRestApi.Contracts` adding Classlib
- `dotnet new webapi -o breakfastRestApi` For WebApi

## To build the Solution

Run below command
`dotnet build`

## To add the created projects to main solution

Run below command
`dotnet sln add .\breakfastRestApi\ .\breakfastRestApi.Contracts\`

# To proceed with building the API

- Add Class files for **Create, Read, Update and Delete**
- Update the WebAPI **Controllers** to Support the FE.
- Now Update the `Program.cs` to fit the webapi
