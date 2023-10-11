# Grover Gaming Tech Test

In this application you can manage the Employee Directory by viewing, adding, updating and removing employees using Windows Forms .NET/C#.
The structure of the project is created with the help of Dependency Injection design pattern, which helps me to create loosely coupled classes. It will also allow me to make future changes inside the application more comfortable and much faster. Overall this is the great way to make code maintanable.
Another technology I am using in this project is the ORM framework called Entity Framework. It helps me to work with the database using .NET objects. It saves data stored in the properties of entities and also retrieves data from the database and converts it to entities objects automatically.
There were some challanges like Dependency Injection setting and services configuring in application. But everything was organized and deployed.

To test this application you have to follow next steps:
1. Download the project with ZIP archive and extract it to a separate folder.
2. Open project .sln file using Visual Studio.
3. Build and run the "EmployeeDirectory" project.
4. After application opening you can try out all the functions by clicking the buttons and filling out forms.

Some advices:
- If you want to clean up the database you can uncomment line 24 in 'MainForm.cs' file and rebuild the project.
- If you would like to change default employees data, you can modify it in 'EmployeeContext.cs' file.
