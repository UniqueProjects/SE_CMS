using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Web_Pages_Main : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //location objLocationField = new LocationField();
        //BAL objBALloaction =new BAL();
       // objBALloaction.InsertLocation(objLocationField);        
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
}