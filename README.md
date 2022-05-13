# ReproBuy
ReproBuy is an .NET application (3.1) that allows users to buy and sell products on the page using MSSQL as the database. It stores and pulls information from the database when needed. It also has a variation of Java Script to enhance the user's experience.
-In order to apply this to your application, you will need to add an appsettings
-You will have to have an MSSQL running (WILL NOT WORK WITH MYSQL) wether through a local DB or a remote DB
-Within your appsettings.json, you will have to add a Connection String with a default string connecting to the dB
EXAMPLE:
{
  "ConnectionStrings": {
    "Default": "//"Server=(localdb)\\mssqllocaldb;Database=thi5-i5-4n-3x4mpl3-0f-4-d4t4-b453-n4m3;Trusted_Connection=True;MultipleActiveResultSets=true""
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
I appreciate the time taking to look over the project and I appreciate the support!
