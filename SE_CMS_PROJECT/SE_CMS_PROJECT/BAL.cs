using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SE_CMS_PROJECT
{
    public class BAL
    {
        public Int32 InsertLocation(LocationField obj)
        {

            DAL objDAL = new DAL();
            try
            {
                return objDAL.InsertLocation(obj);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                objDAL = null;
            }
        }

        public DataSet GetLocations()
        {
            DataSet ds = new DataSet();
            DAL objDAL = new DAL();
            try
            {
                return objDAL.GetLocations();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                objDAL = null;
            }
        }

        public Int32 DisableLocation(LocationField obj)
        {
            DAL objDAL = new DAL();
            try
            {
                return objDAL.DisableLocation(obj);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                objDAL = null;
            }
        }

        public Int32 UpdateLocation(LocationField obj)
        {
            DAL objDAL = new DAL();
            try
            {
                return objDAL.UpdateLocation(obj);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                objDAL = null;
            }
        }



    }



}