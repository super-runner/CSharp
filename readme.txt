Open the Extensions and install the C# extension: 
    Name: C#, ,
    Id: ms-vscode.csharp ,
    Description: C# for Visual Studio Code (powered by OmniSharp). ,
    Publisher: Microsoft ,VS Marketplace Link: https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp


# Open cmd and cd into a folder of your choice
    dotnet new console -o myapp # This will create a new console project (project file myapp.csproj)
    cd myapp
    code .                      # Start VS Code by typing Code .


# In VS Code goto Terminal and execute the following command to run your application
    dotnet run --project myapp 
# or just run
    dotnet run

# Alternatively you can start Debugging (F5)

This should provide you a good start where you then can use your code.

There is a also video introduction for this available at 
    https://channel9.msdn.com/Blogs/dotnet/Get-started-VSCode-Csharp-NET-Core-Windows