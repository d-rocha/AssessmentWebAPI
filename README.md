<h3 align="center">
  Assessment WebAPI
</h3>

<h3 align="center">
  <img alt="C#" 
    src="https://live.staticflickr.com/65535/50991403782_0cdf5ab8df_m.jpg" width="180px"/>
</h3>

<hr/>

## 🚀 Briefing

    Academic evaluation for Infnet Institute.

Application developed in C#. The application is simple and of standard Visual Studio creation, using the ASP.NET Core MVC framework.

This application must be both of the Web API type and must allow employees of a publisher to manage the books and authors of that publisher.

This publisher hopes to be able to create a mobile application soon, so it is important that all of these features are also available through a Web API service.

This service consists of:

```bash
- A GET method for searching for a list of books.
- A GET method for searching for a book.
- A POST method for including a book.
- A PUT method for updating a book.
- A DELETE method for deleting a book.
- A GET method for searching for a list of authors.
- A GET method for searching for an author.
- A POST method for creating an author.
- A PUT method for updating an author.
- A DELETE method for deleting an author.
```

Books must contain the fields id, title, ISBN and year, in addition to their list of authors.

Authors must contain the fields id, name, surname, email and date of birth, in addition to their list of books.

It is in the registration of a book that the relationship of the book with the authors is established. In the registration of an author, books are not assigned to him.

This web application should allow only authenticated and authorized users to perform these operations.

It is important to highlight that you must create, in the database, the Book and Author tables, their relationships, the models in the application, the strongly typed views, the controllers and the necessary validations.

You must use the Entity Framework and you can choose the model you prefer: Data First, Model First or Code First. Access to the database must be placed in a library.

The student must put the logic of the operations, which would be common to the controllers, both of the MVC and of the Web API, in another library, so that there is no repetition of code.


## 🏁 Run this project:

To run on the first time,  
into your folder:

```bash
$ git clone https://github.com/d-rocha/AssessmentWebAPI
```

## Project execution:
### Visual Studio 2019 or Visual Studio Code
Community or professional or enterprise version required

```
Visual Studio => https://visualstudio.microsoft.com/pt-br/vs/community/
```

```
VSCode => https://code.visualstudio.com/
```

### This project was developed in visual studio 2019, if you want to run on vscode, 
### follow the documentation below to configure

### 📋 Links:

```
https://docs.microsoft.com/pt-br/dotnet/core/tutorials/with-visual-studio-code
```

```bash
http://www.macoratti.net/17/01/aspnc_prj1.htm
```

😃 Now run the project and...
**BE HAPPY**.

<h4>
  😍 Thanks for you interest! 
</h4>

<br/>

---

<h3 align="center">
Author: <a alt="Davi-Rocha" href="#author-davi-rocha">Davi Rocha</a>
</h3>

<p align="center">

  <a alt="Davi Rocha" href="https://www.linkedin.com/in/davirochaoliveira/">
    <img src="https://img.shields.io/badge/LinkedIn-Davi_Rocha-0077B5?logo=linkedin"/></a>
  <a alt="Davi Rocha" href="https://github.com/d-rocha">
  <img src="https://img.shields.io/badge/d_rocha-GitHub-000?logo=github"/></a>

</p>
