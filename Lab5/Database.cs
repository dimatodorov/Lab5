using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab5
{
    public class Database
    {
        public Product Product
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Sales Sales
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Shop Shop
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void main()
        {
            Product product = new Product();
            Sales sales = new Sales();
            Shop shop = new Shop();
            //product.Add(7, "sdgsfgsf", 3);
            //sales.Add(8, 2, 3, 3);
            //shop.Add(3, "sdfhdsgh");
            //product.Update(1, "sdgsd", 45);
            //product.Del(7);
            product.Show();

        }
    }
}
