using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFChocolate.AppConnect;

namespace WPFChocolate.ApplicationData
{
    public partial class Sale
    {
        public int[] ProductInSale
        {
            get 
            { 
                int[] products = AppConnection.model.ProductSale.Where(x => x.IDSale == ID).Select(x => x.Product.ID).ToArray();

                for (int i = 0; i < products.Length; i++)
                {
                    int artBuf = products[i];
                    products[i] = AppConnection.model.Product.Where(p => p.ID == artBuf)
                        .Select(p => p.ID).FirstOrDefault();
                }
                return products;
            }
        }
    }
}
