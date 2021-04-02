## <div align="center"> Parks Lookup API
#### <div align="center">📚 *Epicodus Independent Project # 12  (Week 6 of C#)  04/02/2021* </div> 
***<p align="right">By Daniel Adeyemi***</p>   
<p align="center"> 
<p align="center">
<img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/csharp/csharp-original.svg" alt="csharp" width="30" />
<img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/dot-net/dot-net-original-wordmark.svg" alt="dotnet" width="30"/>
<img alt="MySQL" width="30px" src="https://raw.githubusercontent.com/github/explore/80688e429a7d4ef2fca1e82350fe8e3517d3494d/topics/mysql/mysql.png" /> 
</p>

<img src="https://cdn.cheapism.com/images/National_Park_Photos.2e16d0ba.fill-1440x605.png" alt="Lake view"/>

<a name="description"></a>
## <div align="center"> 🚩 *Description*:</div>    

##### ***This is a custom API to lookup national and local parks by name, location etc .***
<hr>


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