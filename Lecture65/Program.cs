using System;
using System.Globalization;
using CsvHelper;
using Lecture65;



var reader = new StreamReader("sample_data.csv");   // to read the input file

var csv = new CsvReader(reader, CultureInfo.InvariantCulture);     // for csv file a reader

var records = csv.GetRecords<Product>();  // to read the records from the csv file


/// Display all products which starts with 'P' and we only need the name, city and country

//records.Where(product => product.Name.StartsWith("P"))
//                   .Select(product => new      // we create a annonymous type object
//                   {
//                       product.Name,
//                       product.City,
//                       product.Country
//                   })
//                   .ToList()
//                   .ForEach(item => Console.WriteLine($"{item.Name} : {item.City} : {item.Country}"));


/// when we use the upper query by storing the result in a variable then we will use the below query

//foreach(var item in query)
//{
//Console.WriteLine($"{item.Name} : {item.City} : {item.Country}");
//}


/// Display top 10 products w.r.t price

//records.OrderByDescending(p => p.Price)
//                   //.Take(10)   // for top 10
//                   .Skip(10)     // all except top 10
//                   .ToList()
//                   .ForEach(item => Console.WriteLine($"{item.Name} : {item.Price}"));


/// Display count of products w.r.t country where year > 2020

//records.Where(p => p.Year > 2020)
//            .GroupBy(p => p.Country)   // group by country
//            .Select(g => new
//            {
//                g.Key,    // here key is the country, if we store this in a variable then we can use it in the below query in for each loop
//                Count = g.Count()
//            })
//            .OrderBy(p => p.Key)   // order by count
//            .ToList()
//            .ForEach(u => Console.WriteLine($"{u.Key} : {u.Count}"));



/// But if we want to display 0 if there is no product in that country

//records.GroupBy(p => p.Country)   
//            .Select(g => new
//            {
//                g.Key,   
//                //Count = g.Where(p => p.Year > 2035).Count()    /// we can do like this or like below
//                Count = g.Count(p => p.Year > 2035)
//            })
//            .OrderBy(p => p.Key)  
//            .ToList()
//            .ForEach(u => Console.WriteLine($"{u.Key} : {u.Count}"));



/// Display all products that are in atleast two countries

//records.Where(p => p.Price > 10)
//    .Select(p => new { Name = p.Name.Substring(0, 4), p.Country })
//    .GroupBy(p=> p.Name )
//    .Select(p=> new {p.Key, NumberOfProducts = p.Distinct().Count()} )
//    .Where(p=> p.NumberOfProducts >= 2 )
//    .ToList()
//    .ForEach(u => Console.WriteLine($"{u.Key} : {u.NumberOfProducts}"));



/// Display the average price of products in each country

//records.GroupBy(p => p.Country)
//    .Select(g => new
//    {
//        g.Key,
//        AveragePrice = g.Average(p => p.Price)
//    })
//    .ToList()
//    .ForEach(u => Console.WriteLine($"{u.Key} : {u.AveragePrice}"));



/// Display no of products in a particular range of price

records.GroupBy(p => p.Price switch { 
    <= 30 => "0 to 30",
    <= 60 => "31 to 60",
     _ => "61 and above",
}).Select(p=> new {p.Key, NoOfProducts = p.Select(p=>p.Name).Distinct().Count() })
.ToList()
.ForEach(u => Console.WriteLine($"{u.Key} : {u.NoOfProducts}"));