# ConsoleSample

C# project sample for non windows environment.
Here is instructions to create simple console application working on Mac.

# Workflow: Create Console Application

Donwload & install `dotnet` tool chain

- https://www.microsoft.com/net/core?WT.mc_id=Blog_CENews_Announce_CEA#macos

Create project folder.

```
$ mkdir ConsoleSample
$ cd ConsoleSample
```

Create Solution file.

```
$ dotnet new sln
```

Create Application project.

```
$ mkdir App
$ cd App
$ dotnet new console
$ cd ..
```

Now, we get a following directory tree.

```
$ tree
.
├── App
│   ├── App.csproj
│   └── Program.cs
└── ConsoleSample.sln
```

Following file was created by `dotnet new console`

```cs:App/Program.cs
using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
```

Add App project to Solution file.

```
$ dotnet sln ConsoleSample.sln add App/App.csproj
```

Restore & Build

```
$ dotnet restore
$ dotnet build
```

Run

```
$ dotnet run --project App/App.csproj
Hello World!
```

# Workflow: Add Library

Now, we'll try to add Json.NET.

```
$ dotnet add App/App.csproj package Newtonsoft.Json
```

Revise program to use JSON library.

```cs:App/Program.cs
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, string>() {{"message", "Hello World!"}};
            var serialized = JsonConvert.SerializeObject(dictionary);
            Console.WriteLine(serialized);
        }
    }
}
```

Run

```
$ dotnet run --project App/App.csproj
{"message":"Hello World!"}
```

