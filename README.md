## <div align="center"> Parks Lookup API 
#### <div align="center">📚 *Epicodus Independent Project # 12  (Week 6 of C#)  04/02/2021* </div> 
***<p align="right">By Daniel Adeyemi***</p>   
<p align="center"> 
<p align="center">
<img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/csharp/csharp-original.svg" alt="csharp" width="30" />
<img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/dot-net/dot-net-original-wordmark.svg" alt="dotnet" width="30"/>
<img alt="MySQL" width="30px" src="https://raw.githubusercontent.com/github/explore/80688e429a7d4ef2fca1e82350fe8e3517d3494d/topics/mysql/mysql.png" /> 
<div align="center">

![GitHub last commit (branch)](https://img.shields.io/github/last-commit/DanielAdeyemi/ParksLookup.Solution/main?color=purple&style=for-the-badge)
</p>

<img src="https://cdn.cheapism.com/images/National_Park_Photos.2e16d0ba.fill-1440x605.png" alt="Lake view"/>

## <div align="center"> 🚩 *Description*:</div>    

#### ***This is a custom API to lookup national and local parks by name, location etc .***
<hr>
<details>
<summary> <h3>🔧 Setup & Requirements</h3></summary>

### 📋 Necessary Specifications

#### To run this project locally you will need:

- **ASP .NET Core :** You can check if you have .NET Core by running `dotnet --version` in the command line. If you do not have .NET Core please find more information and download [here](https://dotnet.microsoft.com/download/dotnet-core)
- **MySQL :**  You can download MySQL [here](https://dev.mysql.com/downloads/file/?id=484914) and MySQL Workbench [here](https://dev.mysql.com/downloads/file/?id=484391)

### ⚙️ Clone or Download

#### 🌐 To Download:

* Go to my GitHub repository, using following [URL](https://github.com/DanielAdeyemi/ParksLookup.Solution.git).
* * At the top of the repository, click <img src="https://i.imgur.com/Ej9Dphm.png" alt="Code Button" height="20" align="center" /> then select "Download ZIP".

<img src="https://i.imgur.com/tZKvGne.gif" alt="download zip gif" height="200"/>

#### <img src="https://raw.githubusercontent.com/github/explore/80688e429a7d4ef2fca1e82350fe8e3517d3494d/topics/terminal/terminal.png" width="18"/> To clone (my prefered method):

1. At the top of the repository, click <img src="https://i.imgur.com/Ej9Dphm.png" alt="Code Button" height="20" align="center" /> and copy the URL.
2. Open Terminal or GitBash and input the command: `git clone https://github.com/DanielAdeyemi/ParksLookup.Solution.git`
3. To view the code, open the copied directory with Visual Studio Code or your preferred text editor by inputing the command `code .` in your terminal.

### 🧰 Database Setup Options

#### AppSettings:

- After you have the project on your computer you will need to create a file in the root directory of the project called "appsettings.json". 
- Add the following snippet of code to the appsettings.json file:

```
{
    "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "Microsoft": "Information",
      "System": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=daniel_adeyemi;uid=[YOUR-ACCOUNT-NAME];pwd=[YOUR-PASSWORD];"
  }
}
```
*Please note you will need to replace `YOUR-PASSWORD-HERE` with the password you created for your MySQL server.
*You may also need to update `uid`, `port`, or `database` name depending on your configurations.

#### Import Database using Entity Framework Core:

 - In the command line run ` cd Desktop/ParksLookup.Solution/ParksLookup` to navigate to the "ParksLookup" folder. 
 - Next, run `dotnet ef database update` to generate the database. You can confirm the database was created by checking MySQL workbench.

*⚠️ Note: to make changed to the database you can run `dotnet ef migrations add <MigrationName>`*
</details>

<details>
<summary> <h3>🛸 API Documentation</h3></summary>

*In order to explore the endpoints of this API, we suggest that you use [Postman](https://www.postman.com/). Postman will allow you to make GET, POST, PUT, and DELETE requests with the `ParksLookupApi`.*
Base URL: `http://localhost:5000`  
#### **HTTP Request Structure:**
```
GET /api/parks
GET /api/parks/{id}
POST /api/parks
PUT /api/parks/{id}
DELETE /api/parks/{id}
```
#### **Path Parameters:**   
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| ParkName | string | none | false| Return matches by name.
| Location | string | none | false | Return matches by location (check note below for comma separated locations such `Portland, OR`). 
| National | bool | none | false | Return all parks marked as **National** |
| Local | bool | none | false | Return all parks marked as **Local** |

*⚠️ Note: for comma-separated locations, such `Portland, OR` use following path:*   
```
?location=portland%2C%20or
```

#### **Example Query:**
```
http://localhost:5000/api/parks/?location=portland%2C%20or&local=true
```
#### **Sample JSON Response:**
```
[
  {
    "parkId": 1,
    "parkName": "Buike",
    "parkLocation": "Portland, OR",
    "national": false,
    "local": true
  }
]
```
</details>


## 🛠️ *Technologies used:*
* C# 9
* .NET Core v5.0
* RESTful Routing, CRUD 
* MySQL MySQL Workbench
* Entity Framework Core
* Postman
* Git and GitHub

## 🐛 *Known bugs:*
No bugs as of 4/2/2021

## 🌟 *Improvement opportunities:*
* build views
* add more features(such as login etc) to make it more useful in real world.


## 📬 Contact Information
#### For any questions *[email author](mailto:adeyemidany+github@gmail.com?subject=[GitHubAPI])*



## 📘 *License and copyright:*

> ***© Daniel Adeyemi, 2021***  
> ⚖️ *[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)*