using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SE_CMS_PROJECT
{
    public class DAL
    {

        public DAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }


        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
        public Int32 InsertLocation(LocationField objBEL)
        {
            int result;
            try
            {
                SqlCommand cmd = new SqlCommand("InsertLocation", con);
                cmd.CommandType = CommandType.StoredProcedure; 
               // cmd.Parameters.AddWithValue("@Location_Id", objBEL.Location_Id);
                cmd.Parameters.AddWithValue("@Location_Name", objBEL.Location_Name);
                cmd.Parameters.AddWithValue("@Location_Latitude", objBEL.Location_latitude);
                cmd.Parameters.AddWithValue("@Location_Longitude", objBEL.Location_Longitude);
                cmd.Parameters.AddWithValue("@Location_Status", objBEL.Location_Status);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                if (result > 0)
                {
                    return result;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }



        public Int32 UpdateLocation(LocationField objBEL)
        {
            int result;
            try
            {
                SqlCommand cmd = new SqlCommand("UpdateLocation", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Location_Id", objBEL.Location_Id);
                cmd.Parameters.AddWithValue("@Location_Name", objBEL.Location_latitude);
                cmd.Parameters.AddWithValue("@Location_Latitude", objBEL.Location_Longitude);
                cmd.Parameters.AddWithValue("@Location_Longitude", objBEL.Location_Name);
                cmd.Parameters.AddWithValue("@Location_Status", objBEL.Location_Status);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                if (result > 0)
                {
                    return result;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }
        public DataSet GetLocations()
        {
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand("GetLocation", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                ds.Dispose();
            }
            return ds;
        }
        public Int32 DisableLocation(LocationField objBEL)
        {
            int result;
            try
            {
                SqlCommand cmd = new SqlCommand("DisableLocation", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Location_Id", objBEL.Location_Id);
                cmd.Parameters.AddWithValue("@Location_Status", objBEL.Location_Status);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                emptylocationfield(objBEL);
                if (result > 0)
                {
                    return result;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }

        public void emptylocationfield(LocationField objBEL)
        {
            objBEL.Location_Id = -1;
            objBEL.Location_Name = "";
            objBEL.Location_latitude = "";
            objBEL.Location_latitude = "";
            objBEL.Location_Status = true;
        }

        public Int32 CheckLogin(LoginFields objLoginFields)
        {
            DataSet ds = new DataSet();
            try
            {
                int result = 1;
                    SqlCommand cmd = new SqlCommand("CheckLogin", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", objLoginFields.Username);
                cmd.Parameters.AddWithValue("@Password", objLoginFields.Password);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                cmd.Dispose();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                
                cmd.Dispose();
                if (ds.Tables[0].Rows.Count != 0)
                {
                    return result ;
                    //return result;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }

    }


}