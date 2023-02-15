using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program

    {
        static void Main(string[] args)
        {
            AddProduct();
            //SelectProducts();
            //SelectProductWhere();
            //UpdateProducts();
            //DeleteProduct();
        }
     public static void AddProduct()
        {
            ETradeContext eTradeContext= new ETradeContext();
            //context sınıfını çağırıyoruz
            var product = new Product()
            {
                Name = "Telefon",
                UnitPrice = 3225.49M,
                StockAmount = 40
                //product sınıfımı kullanarak tabloya eklemek istediğimiz şeyler
            };
            eTradeContext.Entry(product).State= EntityState.Added;
            // oluşturduğumuz product değişkenini Entityin add özelliğini kullanıyoz
            eTradeContext.SaveChanges();
            //yapılan değişikliği kaydetme
            Console.WriteLine("Ürün eklendi");
            Console.ReadLine();

        }
     public static void SelectProducts()
        {
            ETradeContext edb = new ETradeContext();
            var list = edb.Products.ToList();
            for (int i=0;i<list.Count;i++)
            {
                Console.WriteLine("ID: " + list[i].ID + "Ürün Adı: " + list[i].Name + "Ürün Fiyat: " + list[i].UnitPrice + "Ürün Stok: " + list[i].StockAmount);
            }
            Console.ReadLine();
        }
     public static void SelectProductWhere()
        {
            ETradeContext edb = new ETradeContext();
            var list=edb.Products.Where(p=> p.Name =="Laptop").ToList();
            for (int i = 0; i<list.Count; i++)
            {
 Console.WriteLine("ID: " + list[i].ID + "Ürün Adı: " + list[i].Name + "Ürün Fiyat: " + list[i].UnitPrice + "Ürün Stok: " + list[i].StockAmount);
            }
            Console.ReadLine();  
        }
     public static void UpdateProducts()
        {
            ETradeContext edb = new ETradeContext();
            var product = new Product()
            {
                ID = 2,
                Name = "Ultrabook",
                UnitPrice=4670.55M,
                StockAmount=40

            };
            edb.Entry(product).State= EntityState.Modified;
            edb.SaveChanges();
            Console.WriteLine("Ürün Güncellendi");
            Console.ReadLine();

        }
     public static void DeleteProduct()
        {
            ETradeContext edb= new ETradeContext();
            var product = new Product()
            {
                ID = 3
            };
            edb.Entry(product).State= EntityState.Deleted;
            edb.SaveChanges();
            Console.WriteLine("Ürün Silindi");
            Console.ReadLine();
        }
        

           

    }
}
