using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace SE_CMS_PROJECT
{
    public partial class LocationDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGriview();
            }
        }

        protected void chkview_CheckedChanged(object sender, EventArgs e)
        {



        }
        protected void imgCheckMark_Click(object sender, EventArgs e)
        {
            int selRowIndex = ((GridViewRow)(((ImageButton)sender).Parent.Parent)).RowIndex;
            // CheckBox cb = (CheckBox)GridView1.Rows[selRowIndex].FindControl("chkstatus");
            ImageButton cb = (ImageButton)GridView1.Rows[selRowIndex].FindControl("imgCheckMark");
            HiddenField hdnlocationId = (HiddenField)GridView1.Rows[selRowIndex].FindControl("hdnLocationID");
            BAL objBALloaction = new BAL();
            LocationField objLocationfield = new LocationField();
            if (hdnlocationId.Value != null)
            {
            objLocationfield.Location_Id = selRowIndex;
            if (cb.ImageUrl == "~/Images/tick.jpg")
            {
                objLocationfield.Location_Status = false;
                objLocationfield.Location_Id = Convert.ToInt32(hdnlocationId.Value);
            }
            else
            {
                objLocationfield.Location_Status = true;
                objLocationfield.Location_Id = Convert.ToInt32(hdnlocationId.Value);
            }
            int response = objBALloaction.DisableLocation(objLocationfield);
            if (response > 0)
            {
                BindGriview();
            }

            //Perform your logic
            }
        }
        protected string GetCheckMark(bool Status)
        {
            string Imageurl;
            if (Status)
            return Imageurl = "~/Images/tick.jpg";
            else
            return Imageurl = "~/Images/cross.jpg";
            
        }


        //    if (e.Row.RowType == DataControlRowType.DataRow)
        //{
        //    Image img = e.Row.Cells[0].Controls[0] as Image;
        //    img.ImageUrl = "img" + DataBinder.Eval(e.Row.DataItem, "id") + ".jpg";
        //}

        public void BindGriview()
        {
            BAL objBALloaction = new BAL();
            DataSet ds = objBALloaction.GetLocations();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }
    }
}