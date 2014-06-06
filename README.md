# ASP.NET MVC 5 Template for Xamarin Studio

![](http://cl.ly/image/0U3E3b260K3o/hanssens_aspnetmvc-for-osx.jpg)
A fully working and clean ASP.NET MVC 5 project for Xamarin Studio. Purrs excellent on Mac OSX. 

## In short

* It's an ASP.NET MVC 5 application
* That also means RAZOR support
* Can be run entirely from Xamarin Studio
* Can be updated and extended through NuGet
* It just works...

Drop me a line if you like it [@jhanssens](https://twitter.com/jhanssens)!

## Known Issues
Some known issues with ASP.NET MVC 5 and the current Mono version:

* App relative paths don't work, e.g. using tildes like `~/assets/style.css`
* The view's web.config has teh [`<host factoryType>` disabled](https://github.com/hanssens/aspnetmvc-for-osx/blob/master/source/AspNetMvcForMac/Views/web.config#L13)
* Mono currently supports .NET 4.5, not 4.5.1
* `routes.LowerCaseUrls` isn't supported yet
* System.Web.Entity reference isn't supported yet

