using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Author: Muhammad Suaid

namespace Project_4_Data
{
    public class Products
    {
        public int ProductId { get; set; }      // field defined

        public string ProdName { get; set; }    // field defined

        //Products uniquename = new Products();

        // A copy of Products before updating
        public Products ProductBackup()
        {
            Products backup = new Products();
            backup.ProductId = ProductId;
            backup.ProdName = ProdName;

            return backup;
        }
    }    
}

