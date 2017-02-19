# Xamarin Forms Simple Login With Rest API

This project is one of the simplest ways how to implement login system using Web Service Rest API.

Before we begin, we need to prepare our Web Service.

I created an optional prerequisite in creating your basic web service api using ASP.NET Web API.

Here's the link: https://github.com/deanilvincent/StepsInCreatingBasicASP.NETWebAPI

In this sample web service project, I include the following model class details:

``` html
public class UserDetailCredentials
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
}
```
When you are done creating your web service, we can now proceed in creating our XAMARIN Cross Platform Mobile App project.
