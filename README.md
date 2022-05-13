# ReproBuy

### What is ReproBuy?
ReproBuy is a **.NET application (3.1)** that allows users to buy and sell products on the page using **MSSQL** as the database. It stores and pulls information from the database when needed.

### What does ReproBuy consist of?
The solution consist of **HTML**, **CSS**, **C#**, and **JS** as it's main languages. 

#### HTML and CSS
Have to make the website visually pleasing, right? I use HTML to create the basic framework of the website. It outputs all the C# coding in the back to present it to the front. **CSS** enhances the HTML by adding color and eyecandy to the HTML elements. I used Bootstrap 5 as a framework to allow modern UI designs such as buttons, icons, modals, etc.

#### C#
C# is the main coding language used to communicate with the database and user. When the code is requested, it will pull and show information from the database for the user to see (using HTML), and will also let them push information back into the database (if they need to sell a product). The MSSQL database is remote and has to specifically find that database over the internet (or locally).

C# also is the logic behind the page. You cannot sell a product unless you have an account registered. You also cannot delete or edit other user's product post's as you did not create them. Since the page is a web application, I was able to create if statements, selection statements, and loops, within the web page to allow specific things to show when criteria is met. Being able to be flexible using C#, I was able to be less strict on the user when it comes with creating a product (allow some columns in the database to allow nulls).

#### JavaScript
Java Script enhances user interaction within the page and assisted with able to create a Add To Cart function. I have used some API such as Toastr and QuillJS. Toastr allows some notifications to show when criteria is met. QuillJS allows users to add the product description in a semi-rich text editor to allow the user to present their product in a more presentable state. I also was able to code an Add to Cart function which allows users to grab the products they choose and add it into a cart for checkout.

In order to apply this to your application, you will need to add an appsettings.json file.
You will have to have an MSSQL running (WILL NOT WORK WITH MYSQL) wether through a local DB or a remote DB.
Within your appsettings.json, you will have to add a Connection String with a default string connecting to the dB.
```
EXAMPLE:
{
  "ConnectionStrings": {
    "Default": "Server=(localdb)\\mssqllocaldb;Database=thi5-i5-4n-3x4mpl3-0f-4-d4t4-b453-n4m3;Trusted_Connection=True;MultipleActiveResultSets=true"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*"
}
```
Use the migrations in Nuget package manager in order to create the schema for the Database. Currently there's a problem where it creates the column ImageName as non nullable, it should be nullable. Hopefully will be able to fix this. For now, make sure the table is nullable.

### References
[ToastrJS](https://codeseven.github.io/toastr/)

[QuillJS](https://quilljs.com/)

[JQuery](https://jquery.com/)

[BootStrap](https://getbootstrap.com/)

I appreciate the time taking to look over the project and I appreciate the support!
