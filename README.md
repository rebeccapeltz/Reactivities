https://www.nuget.org/packages/dotnet-ef

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