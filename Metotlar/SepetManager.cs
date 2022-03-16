using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Added to cart : " +product.Name);
        }

    }
}
