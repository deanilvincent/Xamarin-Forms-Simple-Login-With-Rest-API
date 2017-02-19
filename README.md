https://www.nuget.org/packages/Microsoft.Bcl/# Xamarin Forms Simple Login With Rest API

This project is one of the simplest ways how to implement login system using Web Service Rest API.

Before we begin, we need to prepare our Web Service.

I created an optional prerequisite in creating your basic web service api using ASP.NET Web API.

Here's the link: https://github.com/deanilvincent/StepsInCreatingBasicASP.NETWebAPI

In this sample web service project, I included these following model class properties:

``` html
public class UserDetailCredentials
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
}
```
When you are done creating your web service, you can now proceed in creating our Xamarin Cross Platform Mobile App project.

# Basic Steps in Implementing Login System using Xamarin Cross Platform.

### 1.0 Creating the project

1.1 Go to File -> New -> Project (Ctrl+Shift+N)

1.2 Choose Templates -> Visual C# -> Cross Platform and rename the project. (Here I named my project as CrossPlatformBasicLoginSystem) and then Click the "OK"

![capture24](https://cloud.githubusercontent.com/assets/10904957/23104382/c77b7d80-f707-11e6-8e12-cd104b43dd02.PNG)

1.3 A white dialog box will appear and you need to choose the following: Template Blank App, Forms in UI Technology and PCL in Sharing. Then click "Accept" to finalize the project creation.

![capture25](https://cloud.githubusercontent.com/assets/10904957/23104393/0c987d00-f708-11e6-85a4-6b668a59bbfa.PNG)

Now you have successfull created your project. This includes the following projects summary:

1. Main Project Portable (PCL)
2. Project.Droid (Android)
3. Project.iOS (iOS)
4. Project.UWP (UWP)

![capture27](https://cloud.githubusercontent.com/assets/10904957/23104460/4d423c00-f709-11e6-97dc-4de05a273c21.PNG)

### 2.0 Preparing the project environment

2.1 Install the following nuget packages:

- Microsoft.Bcl (https://www.nuget.org/packages/Microsoft.Bcl/)
- Microsoft.Bcl.Build (https://www.nuget.org/packages/Microsoft.Bcl.Build/)
- Microsoft.Net.Http (https://www.nuget.org/packages/Microsoft.Net.Http/)

