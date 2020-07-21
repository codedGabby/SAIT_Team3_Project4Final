using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4_Data
{
    //Author: Yasin Habib
    public class PackageDB
    {
        //Getting all packages
        public static List<Packages> GetAllPackages()
        {
            List<Packages> packages = new List<Packages>();
            Packages pk = null;
            SqlConnection con = TravelExpertConnection.GetConnection();
            string selectStatement = "SELECT * " +
                                     "FROM Packages " +
                                     "ORDER BY PackageId";

            SqlCommand cmd = new SqlCommand(selectStatement, con);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    pk = new Packages();
                    pk.PackgeId = (int)reader["PackageId"];
                    pk.PkgName = reader["PkgName"].ToString();
                    pk.PkgDesc = reader["PkgDesc"].ToString();
                    pk.PkgBasePrice = (decimal)reader["PkgBasePrice"];
                    pk.PkgAgencyCommission = (decimal)reader["PkgAgencyCommission"];
                    packages.Add(pk);


                    //for null values
                    //Added Product
                    int prod = reader.GetOrdinal("Product");
                    if (reader.IsDBNull(prod))
                        pk.Product = null;
                    else
                        pk.Product = reader["Product"].ToString();

                    //Dates
                    int dateStart = reader.GetOrdinal("PkgStartDate");
                    int dateEnd = reader.GetOrdinal("PkgEndDate");
                    if(reader.IsDBNull(dateStart))
                        pk.PkgStartDate = null;
                    else if (reader.IsDBNull(dateEnd))
                        pk.PkgEndDate = null;

                    else // it is not null
                    {
                        pk.PkgStartDate = Convert.ToDateTime(reader["PkgStartDate"]);
                        pk.PkgEndDate = Convert.ToDateTime(reader["PkgEndDate"]);
                    }
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
            return packages;
        }//End of GetAllPackages


        //Update Package
        public static bool UpdatePackage(Packages oldPack, Packages newPack)
        {
            using (SqlConnection con = TravelExpertConnection.GetConnection())
            {
                string updateStatement = "UPDATE Packages " +
                                         "SET PkgName = @NewPkgName, " +
                                         "    PkgDesc = @NewPkgDesc,  " +
                                         "    PkgStartDate = @NewPkgStartDate, " +
                                         "    PkgEndDate = @NewPkgEndDate, " +
                                         "    PkgBasePrice = @NewPkgBasePrice, " +
                                         "    PkgAgencyCommission = @NewPkgAgencyCommission, " +
                                         "    Product = @NewProduct " +
                                         "WHERE PackageId = @OldPackageId " +
                                        "AND PkgName = @OldPkgName " +
                                        "AND PkgDesc = @OldPkgDesc " +
                                        "AND (PkgStartDate = @OldPkgStartDate OR " +                //Nullable
                                        "     PkgStartDate IS NULL AND @OldPkgStartDate IS NULL) " +
                                        "AND (PkgEndDate = @OldPkgEndDate OR " +                     //Nullable
                                        "     PkgStartDate IS NULL AND @OldPkgStartDate IS NULL) " +
                                        "AND PkgBasePrice = @OldPkgBasePrice " +
                                        "AND PkgAgencyCommission = @OldPkgAgencyCommission " +
                                        "AND (Product = @OldProduct OR " +                //Nullable
                                        "     Product IS NULL AND @OldProduct IS NULL)";
                using (SqlCommand cmd = new SqlCommand(updateStatement, con))
                {
                    //******NEW Packages data*********
                    cmd.Parameters.AddWithValue("@NewPkgName", newPack.PkgName);
                    cmd.Parameters.AddWithValue("@NewPkgDesc", newPack.PkgDesc);
                    cmd.Parameters.AddWithValue("@NewPkgBasePrice", newPack.PkgBasePrice);
                    cmd.Parameters.AddWithValue("@NewPkgAgencyCommission", newPack.PkgAgencyCommission);


                    if (newPack.Product == null)
                        cmd.Parameters.AddWithValue("@NewProduct", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@NewProduct", newPack.Product);

                    //New Start date

                    if (newPack.PkgStartDate == null)
                        cmd.Parameters.AddWithValue("@NewPkgStartDate", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@NewPkgStartDate", (DateTime)newPack.PkgStartDate);
                    //New End date
                    if (newPack.PkgEndDate == null)
                        cmd.Parameters.AddWithValue("@NewPkgEndDate", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@NewPkgEndDate", (DateTime)newPack.PkgEndDate);



                    //******OLD Packages data*********
                    cmd.Parameters.AddWithValue("@OldPackageId", oldPack.PackgeId);
                    cmd.Parameters.AddWithValue("@OldPkgName", oldPack.PkgName);
                    cmd.Parameters.AddWithValue("@OldPkgDesc", oldPack.PkgDesc);
                    //old Start date
                    if (oldPack.PkgStartDate == null)
                        cmd.Parameters.AddWithValue("@OldPkgStartDate", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@OldPkgStartDate", (DateTime)oldPack.PkgStartDate);
                    //old End date
                    if (oldPack.PkgEndDate == null)
                        cmd.Parameters.AddWithValue("@OldPkgEndDate", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@OldPkgEndDate", (DateTime)oldPack.PkgEndDate);

                    cmd.Parameters.AddWithValue("@OldPkgBasePrice", oldPack.PkgBasePrice);
                    cmd.Parameters.AddWithValue("@OldPkgAgencyCommission", oldPack.PkgAgencyCommission);


                    if (oldPack.Product == null)
                        cmd.Parameters.AddWithValue("@OldProduct", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@OldProduct", oldPack.Product);

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
                }//2nd using
            }//1st "using"

        }//End of Update

        //Add package
        public static int AddPackage(Packages pack)
        {
            int pkId = 0;
            using (SqlConnection con = TravelExpertConnection.GetConnection())
            {
                string insertStatement = "INSERT INTO Packages " +
                                         "(PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission, Product) " +
                                         "OUTPUT inserted.PackageId " + // output auto-generated ID
                                         "VALUES DISTINCT (@PkgName, @PkgStartDate, @PkgEndDate, @PkgDesc, @PkgBasePrice, @PkgAgencyCommission, @Product) ";
                using (SqlCommand cmd = new SqlCommand(insertStatement, con))
                {
                    cmd.Parameters.AddWithValue("@PkgName", pack.PkgName);
                    cmd.Parameters.AddWithValue("@PkgDesc", pack.PkgDesc);
                    //Start date
                    if (pack.PkgStartDate == null)
                        cmd.Parameters.AddWithValue("@PkgStartDate", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@PkgStartDate", pack.PkgStartDate);
                    //End date
                    if (pack.PkgEndDate == null)
                        cmd.Parameters.AddWithValue("@PkgEndDate", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@PkgEndDate", pack.PkgEndDate);
                    //Product
                    if (pack.Product == null)
                        cmd.Parameters.AddWithValue("@Product", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@Product", pack.Product);


                    cmd.Parameters.AddWithValue("@PkgBasePrice", pack.PkgBasePrice);
                    cmd.Parameters.AddWithValue("@PkgAgencyCommission", pack.PkgAgencyCommission);


                    con.Open();
                    pkId = (int)cmd.ExecuteScalar();
                }//2nd using
            }//1st using
            return pkId;
        } // end AddPackage

    }//End of PackageDB
}//End of Namespace
