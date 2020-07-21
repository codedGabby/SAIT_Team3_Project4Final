using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

// Author: Gabriel Sofekun

namespace Project_4_Data
{

    //Add this on SQL one block after the other
/*
    alter table Products_Suppliers
add SupName nvarchar(255) null;

Update Products_Suppliers
SET Products_Suppliers.SupName = Suppliers.SupName
from Products_Suppliers
join Suppliers
on Suppliers.SupplierId = Products_Suppliers.SupplierId;

    alter table Products_Suppliers
    add ProdName nvarchar(255) null;

Update Products_Suppliers
SET Products_Suppliers.ProdName = Products.ProdName
from Products_Suppliers
join Products
on Products.ProductId = Products_Suppliers.ProductId;
*/
    public class Products_SupplierDB
    {
        public static List<int> GetProductSupplierIDs()
        {
            List<int> productSupplierIDs = new List<int>(); // empty list of IDs
            int id; // for reading
            using (SqlConnection connection = TravelExpertConnection.GetConnection())
            {
                string query = "SELECT ProductSupplierId FROM Products_Suppliers";
                // any exception not handled here is automatically thrown to the form
                // where the method was called
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    // close connection as soon as done with reading
                    while (reader.Read())
                    {
                        id = (int)reader["productSupplierId"];
                        productSupplierIDs.Add(id);
                    }
                } // command object recycled
            } // connection object recycled
            return productSupplierIDs;
        }

        public static List<Products_Supplier> GetProducts_Suppliers()
        {
            List<Products_Supplier> products_Suppliers = new List<Products_Supplier>(); // empty list object
            Products_Supplier ps; // for reading
            using (SqlConnection connection = TravelExpertConnection.GetConnection())
            {
                string selectQuery = "SELECT ProductSupplierId, ProductId, ProdName, SupplierId, SupName" +
                                    " FROM Products_Suppliers" +
                                    " order BY SupplierId";
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    connection.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read()) // while there is data
                        {
                            ps = new Products_Supplier(); // object with no data initialized
                            ps.ProductSupplierId = (int)dr["ProductSupplierId"];
                            ps.ProductId = (int)dr["ProductId"];
                            ps.SupplierId = (int)dr["SupplierId"];
                            ps.ProdName = (string)dr["ProdName"];
                            ps.SupName = (string)dr["SupName"];
                            products_Suppliers.Add(ps);
                        }
                    } // dr gets closed and recycled
                }// cmd gets recycled
            }// connection gets closed, and recycled
            return products_Suppliers;
        }

        public static Products_Supplier GetProductSupplierByID(int productID)
        {
            List<Products_Supplier> products_Supplier = new List<Products_Supplier>(); // empty list object
            //Products_Supplier products_Supplier = new Products_Supplier(); // empty list object
            Products_Supplier psi = null;

            using (SqlConnection connection = TravelExpertConnection.GetConnection())
            {
                string query = "SELECT ProductId, ProductSupplierId, SupplierId FROM Products_Suppliers " +
                                 //"ORDER BY ProductSupplierId " +
                                 " Where ProductId = @ProductId";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@ProductId", productID);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read()) // while there is data
                        {
                            psi = new Products_Supplier();
                            psi.ProductSupplierId = (int)dr["ProductSupplierId"];
                            psi.ProductId = (int)dr["ProductId"];
                            psi.SupplierId = (int)dr["SupplierId"];
                            products_Supplier.Add(psi);
                        }
                    }
                } 
            } 
            return psi;
        }
    
    }//end of class
}//end of namespace
