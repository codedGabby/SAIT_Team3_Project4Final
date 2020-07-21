using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Author: Tony Onyeka
*/
namespace Project_4_Data
{
    public class Suppliers
    {
        public int SupplierId { get; set; }

        public string SupName { get; set; }

        public Suppliers SupplierBackup()
        {
            Suppliers backup = new Suppliers();
            backup.SupplierId = SupplierId;
            backup.SupName = SupName;

            return backup;
        }
    }
}
