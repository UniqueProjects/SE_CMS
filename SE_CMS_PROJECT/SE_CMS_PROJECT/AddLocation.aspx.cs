using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SE_CMS_PROJECT
{
    public partial class AddLocation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnAddLocation_Click(object sender, EventArgs e)
        {
            LocationField objLoctionField = new LocationField();
            objLoctionField.Location_Id = 53;
            objLoctionField.Location_Name = buildingName.Text;
            objLoctionField.Location_latitude = buildingLatitude.Text;
            objLoctionField.Location_Longitude = buildingLongitude.Text;
            objLoctionField.Location_Status = buildingStatus.Checked;

            BAL obj=new  BAL();

            obj.InsertLocation(objLoctionField);



        }
    }
}