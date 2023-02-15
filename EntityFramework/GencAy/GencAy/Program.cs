using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GencAy
{

    public class ETradeContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //provider indir mssql ve connection string.
            optionsBuilder.UseSqlServer("Server=TALHAMCIGINIZ\\SQLEXPRESS;Database=ECommerceDb;Trusted_Connection=True;");
        }
    }
    
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

  



    public class Program
    {
        public static void AddProducts()
        {
            ETradeContext context = new ETradeContext();
            Product product = new Product()  //var product = new Product() ta olur
            {
                Name = "C product",
                Quantity = 7,
                Price = 300.50F
            };
            Product product1 = new Product()  //var product = new Product() ta olur
            {
                Name = "D product",
                Quantity = 2,
                Price = 1200.50F
            };
            Product product2 = new Product()  //var product = new Product() ta olur
            {
                Name = "E product",
                Quantity = 29,
                Price = 100.50F
            };
            context.Products.AddAsync(product);
            context.Products.AddAsync(product1);
            context.Products.AddAsync(product2);
            // context.Products.AddRangeAsync(product,product1,product2); toplu ekleme
            //savechanges transaction'dur ve transaction maliyet gibidir. her üründen sonra değil de en sonda bi tane kullanmak bizim için daha verimli olur.
            context.SaveChanges(); // insert delete ve update sorgularını oluşturup bir transaction eşliğinde database'e gönderip execute eden fonk. Eğer ki oluşturulan srogulardan biri bile çalışmazsa tüm islemleri geri alir.(rollback)
            Console.WriteLine("Product has added.");
            Console.ReadLine();
        }
        public static async void UpdateProducts()
        {
            ETradeContext context = new ETradeContext();
            Product product = await context.Products.FirstOrDefaultAsync(u => u.Id==3);
            product.Name= "H product";
            product.Quantity=5;
            product.Price = 350.7F;

          await context.SaveChangesAsync();
            Console.WriteLine("Product has updated");
            Console.ReadLine();
        }

        public static async void DeleteProducts()
        {
            ETradeContext context = new ETradeContext();
            Product product = await context.Products.FirstOrDefaultAsync(u=> u.Id==5);
            context.Products.Remove(product);
            await context.SaveChangesAsync();
            Console.WriteLine("Product has deleted");

        }
        static void Main(string[] args)
        {
           //AddProducts();
           //UpdateProducts();
           //DeleteProducts();
           Console.ReadLine();
        }
    }

    
}

