using Rema1000.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rema1000.Data
{
    public class DbInitializer
    {
        public void DbInitialize(Rema1000Context context)
        {
            if (context.Product.Any() && context.Product.Any() && context.Category.Any())
            {
                return;   // DB has been seeded
            }

            var categories = new Category[]
            {
                new Category { Name = "Clothes", Description = "bla"},
                new Category { Name = "Food", Description = "bla1"},
                new Category { Name = "Utilities", Description = "bla2"}
            };

            var suppliers = new Supplier[]
            {
                new Supplier { Name = "Coop", Address = "Whateverstan 2000", ZipCode = 1000,
                    Contact = "Karl-Johan", Email = "Exam@letmepass.com", PhoneNumber = 20202020},
                new Supplier { Name = "Tøj-r-us", Address = "Whereeverstan 100", ZipCode = 2000,
                    Contact = "Søren", Email = "Exam@letmepass2.com", PhoneNumber = 30303030},
                new Supplier { Name = "Util Supplies", Address = "herestan 300", ZipCode = 3000,
                    Contact = "Lars", Email = "Exam@letmepass3.com", PhoneNumber = 40404040},
            };

            var products = new Product[]
            {
                new Product { Name = "Kjole",  Description = "A nice dress", Unit = 1,
                    Amount = 1, Price = 1499, Category = categories[0], Stock = 100, Supplier = suppliers[1] },

                new Product { Name = "Trøje",  Description = "A nice sweater", Unit = 2,
                    Amount = 1, Price = 500, Category = categories[0], Stock = 50, Supplier = suppliers[1] },

                new Product { Name = "Frysepizza",  Description = "Quite Delicious", Unit = 1,
                    Amount = 2, Price = 100, Category = categories[1], Stock = 20, Supplier = suppliers[0] },

                new Product { Name = "Bukser",  Description = "A nice set of pants", Unit = 1,
                    Amount = 1, Price = 999, Category = categories[0], Stock = 30, Supplier = suppliers[1] },

                new Product { Name = "Parisertoast",  Description = "Very delicious!", Unit = 1,
                    Amount = 1, Price = 30, Category = categories[1], Stock = 10, Supplier = suppliers[0] },

                new Product { Name = "Lagsagne",  Description = "Even more delicious!", Unit = 1,
                    Amount = 1, Price = 1499, Category = categories[1], Stock = 100, Supplier = suppliers[0] },

                new Product { Name = "Elpærer",  Description = "For when you get bright ideas", Unit = 1,
                    Amount = 3, Price = 30, Category = categories[2], Stock = 10, Supplier = suppliers[2] },

                new Product { Name = "Skruetrækker",  Description = "Just say screw it!", Unit = 1,
                    Amount = 1, Price = 50, Category = categories[2], Stock = 100, Supplier = suppliers[2] },

                new Product { Name = "Ovnrens",  Description = "Clean that oven!", Unit = 1,
                    Amount = 1, Price = 1499, Category = categories[2], Stock = 100, Supplier = suppliers[2] },

                new Product { Name = "Klovborg ost",  Description = "Gotta love me some solidified milk!", Unit = 1,
                    Amount = 1, Price = 60, Category = categories[1], Stock = 10, Supplier = suppliers[1] },

            };
            context.AddRange(categories);
            context.AddRange(suppliers);
            context.AddRange(products);

            context.SaveChanges();
        }
    }
}
