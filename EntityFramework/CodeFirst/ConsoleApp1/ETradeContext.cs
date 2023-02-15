using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Console uyg aç
//nugetten entityframework indir
//classlar ve proplarını oluştur
//app configte connection stringi hallet
// program cs de kodları yaz
namespace ConsoleApp1
{
    public class ETradeContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
