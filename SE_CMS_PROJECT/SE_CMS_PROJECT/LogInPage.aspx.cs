using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SE_CMS_PROJECT
{
    public partial class LogInPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //string username = txtUserName.Text;
            //string password = txtPassword.Text;

            LoginFields objLoginFields = new LoginFields();
            //if (txtUserName.Text != "" || txtPassword.Text != "")
            //{
                objLoginFields.Username = txtUserName.Text;
                objLoginFields.Password = txtPassword.Text;
                BAL objBAL = new BAL();
                
                int result=objBAL.CheckLogin(objLoginFields);
                if (result == 1)
                {
                    Response.Redirect("LocationDetails.aspx", false);
                }
                else
                {
                    ErrorMsg.Text = "Username or Password Invalid";
                    ErrorMsg.Visible = true;
                    txtUserName.Text = "";
                    txtPassword.Text = "";
                }
            
            //else
            //{
            //    ErrorMsg.Text = "Username or Password Invalid";
            //    ErrorMsg.Visible = true;
            //}
            
        }
    }
}