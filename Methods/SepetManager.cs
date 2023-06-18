using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + product.Adi);
        }


        public void Ekle2(string Adi, string Aciklama, double Fiyati, int StokAdedi )
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + Adi);
        }
    }
}
