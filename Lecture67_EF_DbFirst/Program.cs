using System;
using System.Linq;

using Lecture67_EF_DbFirst.Models;
using Microsoft.EntityFrameworkCore;

/// We must download the Microsoft.EntityFrameworkCore.SqlServer and Microsoft.EntityFrameworkCore.Tools package from NuGet


//Scaffold - DbContext "Server=(localdb)\MSSQLLocalDB;Initial Catalog=MYShopDB;Integrated Security=True;" Microsoft.EntityFrameworkCore.SqlServer - OutputDir Models       // we will paste this command in the package manager console, and add " -force " to overwrite the existing files, as we deleted the price column from the database



var db = new MyshopDbContext();

db.Products.ToList().
    ForEach(p =>
    {
        Console.WriteLine($"ID: {p.Id}, Name: {p.Name}");
    });