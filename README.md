# Xamarin Forms Simple Login With Rest API

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
When you are done creating your web service, we can now proceed in creating our Xamarin Cross Platform Mobile App project.

# Basic Steps in Implementing Login System using Xamarin Cross Platform.

### 1.0 Creating the project

1.1 Go to File -> New -> Project (Ctrl+Shift+N)

1.2 Choose Templates -> Visual C# -> Cross Platform and rename the project. (Here I named my project as CrossPlatformBasicLoginSystem) and then Click the "OK"

![capture24](https://cloud.githubusercontent.com/assets/10904957/23104382/c77b7d80-f707-11e6-8e12-cd104b43dd02.PNG)

1.3 A white dialog box will appear and you need to choose the following: Template Blank App, Forms in UI Technology and PCL in Sharing. Then click "Accept" to finalize the project creation.

![capture25](https://cloud.githubusercontent.com/assets/10904957/23104393/0c987d00-f708-11e6-85a4-6b668a59bbfa.PNG)
