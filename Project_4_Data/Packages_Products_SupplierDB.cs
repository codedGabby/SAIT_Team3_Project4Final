using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author: Gabriel Sofekun

namespace Project_4_Data
{
    public class Packages_Products_SupplierDB
    {
        public static List<Packages_Products_Supplier> GetPackages_Products_SupplierByID(int productSupplierId)
        {
            List<Packages_Products_Supplier> packages_Products_Supplier = new List<Packages_Products_Supplier>(); // empty list object
            Packages_Products_Supplier pps; // for reading
            using (SqlConnection connection = TravelExpertConnection.GetConnection())
            {
                string selectQuery = "SELECT PackageId, ProductSupplierId "+
                                     "FROM [Packages_Products_Supplier]" +
                                     "WHERE ProductSupplierId = @ProductSupplierId";

                using (SqlCommand cmd = new SqlCommand(selectQuery, connection)) // build an object an pass it a
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@ProductSupplierId", productSupplierId);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read()) // while there is data
                        {
                            pps = new Packages_Products_Supplier(); // object with no data initialized
                            pps.PackageId = (int)dr["PackageId"];
                            pps.ProductSupplierId = (int)dr["ProductSupplierId"];
                            packages_Products_Supplier.Add(pps);
                        }
                    }
                }
            }
            return packages_Products_Supplier;
        }
    }
}
