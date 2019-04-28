using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cross_Site_Scripting
{
    public partial class greeting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //adding secret cookie to the application
            var secretCookie = new HttpCookie("SecretKeys")
            {
                Value = "Very secret cookie",
                Expires = DateTime.Now.AddYears(1)
            };
            Response.Cookies.Add(secretCookie);



            var username = Request.QueryString["q"];
            if (!string.IsNullOrEmpty(username))
            {
                lbl_welcome.Text = "Welcome to our site " + username;
            }
            else
                lbl_welcome.Text = "Please let us know who are you!";
        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            Response.Redirect("greeting.aspx?q=" + txt_username.Text);

        }
    }
}