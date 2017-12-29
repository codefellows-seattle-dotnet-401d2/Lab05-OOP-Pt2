## Project Name
Author: Jeff Martinez
Version: 1.0.0 

## Overview
This application is built to showcase the principal and importance of inheritance between classes and objects.  In this case, we are "building" a school with different types of courses.  Code Fellows serves as the base class and the breakdown of courses and their properties follows

## Getting Started
1. In order to build this app you must create a base class that will serve as a blueprint for your derived classes
2. You must then create a derived class that can have the option to add more derived classes to inherit propeties from the base and current classes
3. Then add a derived class that may serve as an object to end the path of inheritance

## Example
Base Class to Derived Class setup
![Alt text](CF-Diagram.png?raw=true "Optional Title")

Passing Tests to check for working inheritance
```c#

  [Fact]
        public void CheckCSharpInheritance()
        {
            Assert.Equal("Today, we learned Javascript", CSharp.TeachStudents());
        }

        [Fact]
        public void CheckJavscriptInheritance()
        {
            Assert.Equal("Used as admission to the next class", Javascript.PassFinal());
        }
```

## Architecture
This application is created using ASP.NET Core
- Language: C# 
- Type of Applicaiton: Console Application 

## Change Log
- 12-28-2017 10:30am - Added classes and properties
- 12-28-2017 8:oopm - Added passing Unit Tests
