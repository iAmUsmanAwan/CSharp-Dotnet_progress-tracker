using System;
using System.ComponentModel.DataAnnotations;
using Lecture66;


Console.WriteLine("EF Core");

Product product = new Product();

product.Name = "Bike";
product.Price = 100;

var db = new MyShopContext();

db.Products.Add(product);

await db.SaveChangesAsync();

Console.WriteLine($"Product Added with id : {product.ID}");

// Read data with Linq

db.Products.Where(p => p.Name.StartsWith("B")).ToList()
    .ForEach(p=> Console.WriteLine($"Product name {p.Name} , Price {p.Price} , and Id : {p.ID} "));


// Update data

Console.WriteLine("Updating Product");

var p2 = db.Products.First();
p2.Price = 200;

await db.SaveChangesAsync();


// Delete data

Console.WriteLine("Deleting Product");

var productsToDelete = db.Products.Where(p => p.Price < 101).ToList();    // ToList() materializes the query so we can loop or pass it to RemoveRange

db.Products.RemoveRange(productsToDelete);     // RemoveRange(...) removes all selected products in one go

await db.SaveChangesAsync();


