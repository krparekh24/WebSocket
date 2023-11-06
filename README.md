**Steps to create .NET Core project solution:**

1.	Open Visual Studio.
2.	Click "Create a new project."
3.	In the "Create a new project" window:
•	Search for "ASP.NET Core Web Application."
•	Select it and click "Next."
4.	In the "Configure your new project" window:
•	Enter a name for your project.
•	Choose a location for your project files.
•	Click "Create."

**Configure the Server Project**
1.	In the "Create a new ASP.NET Core Web Application" dialog, select "ASP.NET Core 5.0" as the target framework.
2.	Select the "ASP.NET Core Web Application" template.
3.	Click "Create."
4.	In the "Create a new ASP.NET Core web application" dialog:
•	Choose the "Web Application" template.
•	Ensure "Enable Docker Support" is unchecked.
•	Click "Create."

**Create the Server Code**
1.	In the Solution Explorer, open the "Startup.cs" file. This is where you'll configure your server.
2.	Inside the Configure method, configure WebSocket middleware to handle WebSocket connections. You can use the example provided earlier for the server component code.
3.	Build and run the server project.
   
**Create the Client Project**
1.	In Visual Studio, right-click on the solution in Solution Explorer.
2.	Select "Add" -> "New Project."
3.	Search for "ASP.NET Core Web Application."
4.	Select it and click "Next."
5.	In the "Configure your new project" window:
•	Enter a name for your client project.
•	Choose a location for your project files.
•	Click "Create."

 **Configure the Client Project**
1.	In the "Create a new ASP.NET Core Web Application" dialog, select "ASP.NET Core 5.0" as the target framework.
2.	Choose the "Web Application" template.
3.	Click "Create."
   
 **Create the Client Code**
1.	In the Solution Explorer, open the "Startup.cs" file for the client project.
2.	Inside the Configure method, create a WebSocket client to connect to the server. You can use the example provided earlier for the client component code.
3.	Create an HTML page with JavaScript to display data received from the server.
   
 **Run Both Projects**
1.	Set multiple startup projects in Visual Studio. Right-click on the solution in Solution Explorer, choose "Set Startup Projects," and select "Multiple startup projects." Set both the server and client projects to "Start."
2.	Build and run the solution.


