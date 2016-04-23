using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using System.Configuration;
using System.Collections.Generic;

namespace SE_CMS_PROJECT
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {            LocationField objlocationfield = new LocationField();
            BAL objBALloaction =new BAL();
            //objBALloaction.InsertLocation(objlocationfield);
            // objBALloaction.UpdateLocation(objlocationfield);
            DataSet ds = objBALloaction.GetLocations();
            
                string ans = JsonConvert.SerializeObject(ds.Tables[0], Formatting.Indented);
            // string result = JsonConvert.SerializeObject(DatatableToDictionary(ds.Tables[0], "Location_Id"), Newtonsoft.Json.Formatting.Indented);
            //            string LocJson = DataTableToJSONWithJavaScriptSerializer(ds.Tables[0]);
            //       string   locjson= LocJson.Replace(@"\","");
            //      hndLocJson.Value = locjson;
            //  string result = JsonConvert.SerializeObject(DatatableToDictionary(ds.Tables[0], "Title"), Newtonsoft.Json.Formatting.Indented);
            //  objBALloaction.DisableLocation(objlocationfield);
            // objBALloaction.InsertLocation(objlocationfield);        
            // Create MySQLConnection Object
            // SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Data Source=IAMLEGEND\SQLSERVER;Initial Catalog=GMS;Integrated Security=True"].ConnectionString);
            SqlConnection connection = new SqlConnection(@"Data Source=IAMLEGEND\SQLSERVER;Initial Catalog=GMS;Integrated Security=True");
            //Sample Select Query 
            //string strSQL = "SELECT *  FROM GMS_Location";

            ////Open the Connection
            //connection.Open();

            ////Create MySqlDataAdapter object and assign the query and connection to it
            //SqlDataAdapter mydata = new SqlDataAdapter(strSQL, connection);

            ////Create MySqlCommandBuilder object
            //SqlCommandBuilder cmd = new SqlCommandBuilder(mydata);

            ////Dataset to hold the values
            //DataSet ds = new DataSet();

            ////Fill the data from MYSQL DB
            //mydata.Fill(ds);

            // YourGridView.DataSource = ds;
            // YourGridView.DataBind();

            //Close the connection
            connection.Close();
        }
        public string DataTableToJSONWithJSONNet(DataTable table)
        {
            string JSONString = string.Empty;
            JSONString = JsonConvert.SerializeObject(table);
            return JSONString;
        }


        public string DataTableToJSONWithJavaScriptSerializer(DataTable table)
        {
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> parentRow = new List<Dictionary<string, object>>();
            Dictionary<string, object> childRow;
            foreach (DataRow row in table.Rows)
            {
                childRow = new Dictionary<string, object>();
                foreach (DataColumn col in table.Columns)
                {
                    childRow.Add(col.ColumnName, row[col]);
                }
                parentRow.Add(childRow);
            }
            return jsSerializer.Serialize(parentRow);
        }


    }
   
}