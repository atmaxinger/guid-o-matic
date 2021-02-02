# GUID-O-MATIC

GUID-O-MATIC is a small utility that runs in the background and generates GUIDs whenever CTRL-ALT-G is pressed.


![Screenshot](https://github.com/atmaxinger/guid-o-matic/raw/master/screenshot.png)


## Building

GUID-O-MATIC is a .NET 5 Windows application. In order to build it, you need to have the [.NET 5 SDK](https://dotnet.microsoft.com/download) installed.

Using Visual Studio: the folder `src` contains the Visual Studion Solution file.

Using the command line:

```
cd src
dotnet --configuration Release build
```

or 

```
cd src
dotnet --configuration Release publish
```


## Acknowledgements

- [Global HotKey hook code from StackOverflow](https://stackoverflow.com/questions/2450373/set-global-hotkeys-using-c-sharp)
- [Icons made by Kiranshastry form www.flaticon.com](https://www.flaticon.com/authors/kiranshastry)