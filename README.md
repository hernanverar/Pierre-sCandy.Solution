# Pierre'Candy Solution

## description:

This an MVC web application for Pierre's Sweet and Savory Treats to track their Treats and flavors.

## By Hernan Verar

## Technologies Used:
* C#
* Dotnet 6.0
* MySql
* ASP.NET Core
* MVC
* Entity Framework Core
* Pomelo Entity Framework Core
* EF Core Migrations
* HTML Helpers
* Css


## Setup/Installation Req's:

### Set Up and Run Project
1. Clone this repo. https://github.com/hernanverar/Pierre-sCandy.Solution.git
2. Open the terminal and navigate to this project's production directory called "PierrreSweets".
3. Within the production directory "PierreSweets", create a new file called `appsettings.json`.
4. Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL. For the LearnHowToProgram.com lessons, we always assume the `uid` is `root` and the `pwd` is `epicodus`.

```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=;uid=[YOUR SQL USERNAME];pwd=[YOUR SQL PASSWORD];"
  }
}
```
5. Run ```dotnet watch run``` to view the project in your web browser. Enter your computer password when prompted.


### Set up the Databases

In your terminal- in the project directory (Pierre-Candy.Solution/PierreSweets), run ```dotnet ef database update```

## Known Bugs

* If you are experiencing any bugs, please contact Hernanverar@gmail.com
# License; MIT License

Copyright (c) [2023] [Hernan Verar]

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NON INFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
