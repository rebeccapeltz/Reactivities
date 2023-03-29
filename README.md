https://www.nuget.org/packages/dotnet-ef

## class repo
https://github.com/TryCatchLearn/Reactivities

install dotnet entity framework
dotnet tool list -g
or
dotnet tool update --global dotnet-ef --version 7.0.4

dotnet tool install --global dotnet-ef --version 7.0.4
cat << \EOF >> ~/.zprofile
# Add .NET Core SDK tools
export PATH="$PATH:/Users/rebeccapeltz/.dotnet/tools"
EOF

export PATH="$PATH:/Users/rebeccapeltz/.dotnet/tools"

dotnet ef

dotnet ef migrations add InitialCreate -s API -p Persistence
starter project API must have reference fro Microsoft.EntityFrameworkCore.Design

dotnet ef database
drop or update

application startup

creating a database dotnet run
/Users/rebeccapeltz/projects/dotnet/demo/Reactivities/API/WeatherForecast.cs(11,18): warning CS8632: The annotation for nullable reference types should only be used in code within a '#nullable' annotations context. [/Users/rebeccapeltz/projects/dotnet/demo/Reactivities/API/API.csproj]

dotnet watch

templates: dotnet new -l
dotnet gitignore file
dotnet new gitignore


ignore appsettings.json and put confidential settings in there

## Client app
npx create-react-app client-app --use-npm --template typescript

## style
https://react.semantic-ui.com/
 npm install semantic-ui-react semantic-ui-css
 `import 'semantic-ui-css/semantic.min.css'`

 ## architecture

 Controller <--> Application
 API Controller -> Mediator.Send() -> Mediator handler -> Object out 
 use case: get activity from DB

 CQRS: commands (no returns, modify state) vs queries separation (returns a value, doesn't  modify state)

 Persistence gets updated or queried by command/query
 eventual consistency to copy denormalized data (like mongodb) from command db to query db



MediatR.Extensions.Microsoft.DependencyInjection by Jimmy Bogard
v11.1.0
MediatR extensions for ASP.NET Core   -> Application.csproj
## Edit
Automapper
AutoMapper.Extensions.Microsoft.DependencyInjection by Jimmy Bogard
v12.0.0
AutoMapper extensions for ASP.NET Core



