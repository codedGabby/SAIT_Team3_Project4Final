using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Author: Muhammad Suaid

namespace Project_4_Data
{
    public class ProductDB
    {
        //Getting all products
        public static List<Products> GetAllProducts()
        {
            List<Products> products = new List<Products>();
            Products pr = null;
            SqlConnection con = TravelExpertConnection.GetConnection();
            string selectStatement = "SELECT * " +
                                     "FROM Products " +
                                     "ORDER BY ProductId";
            SqlCommand cmd = new SqlCommand(selectStatement, con);
            //con.Open();
            //SqlDataReader reader = cmd.ExecuteReader();
            //if (!reader.HasRows) 
            //{
            //    MessageBox.Show("Product Name has to be unique")
            //}
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) // while there is another record
                {
                    pr = new Products();
                    pr.ProductId = (int)reader["ProductId"];
                    pr.ProdName = reader["ProdName"].ToString();
                    products.Add(pr);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return products;
        }//End of GetAllProducts      

        //Update Product
        public static bool UpdateProduct(Products oldProd, Products newProd)
        {
            using (SqlConnection con = TravelExpertConnection.GetConnection())
            {
                string updateStatement = "UPDATE Products " +
                                         "SET ProdName = @NewProdName " +
                                         "WHERE ProductId = @OldProductId " +
                                        "AND ProdName = @OldProdName ";
                //"ADD CONSTRAINT ProdNam UNIQUE (ProductId, ProdName)";

                using (SqlCommand cmd = new SqlCommand(updateStatement, con))
                {
                    //******NEW Products data*********
                    cmd.Parameters.AddWithValue("@NewProdName", newProd.ProdName);

                    //******OLD Products data*********
                    cmd.Parameters.AddWithValue("@OldProductId", oldProd.ProductId);
                    cmd.Parameters.AddWithValue("@OldProdName", oldProd.ProdName);
                    try
                    {
                        con.Open();
                        int count = cmd.ExecuteNonQuery();
                        if (count > 0) return true;
                        else return false;
                    }
                    catch (SqlException ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }
        // Add Product
        public static int AddProduct(Products prod)
        {
            int prId = 0;
            using (SqlConnection con = TravelExpertConnection.GetConnection())
            {
                string insertStatement = "INSERT INTO Products " +
                                         "(ProdName) " +
                                         "OUTPUT inserted.ProductId " + // output auto-generated ID
                                         "VALUES(@ProdName)";
                using (SqlCommand cmd = new SqlCommand(insertStatement, con))
                {
                    cmd.Parameters.AddWithValue("@ProdName", prod.ProdName);
                    con.Open();
                    prId = (int)cmd.ExecuteScalar();
                }
            }
            return prId;
        }
        //public static bool IsProdNameUnique(string prodName)
        //{
        //    bool valid;
        //    List<Products> products = new List<Products>();
        //    using (SqlConnection con = TravelExpertConnection.GetConnection())
        //    {
        //        string productstatement = "Select ProductId, ProdName " +
        //                                    "From Products ";
        //        using (SqlCommand cmd = new SqlCommand(productstatement, con))
        //        {
        //            cmd.Parameters.AddWithValue("@ProdName", prodName);
        //            con.Open();

        //            using (SqlDataReader reader = cmd.ExecuteReader())
        //            {
        //                if (reader.Read())
        //                {
        //                    Products product = new Products();

        //                    product.ProductId = (int)reader["ProductId"];
        //                    product.ProdName = Convert.ToString(reader["ProdName"]);

        //                    products.Add(product);
        //                }                    
        //            }
        //            if (products.Count < 0)
        //            {
        //                valid = true;
        //            }
        //            else
        //            {
        //                valid = false;
        //            }                       
        //        }            
        //    }
        //    return valid;
        //}
    }
}


