using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security.AntiXss;

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
                Expires = DateTime.Now.AddYears(1),
                HttpOnly = true, // always set the HttpOnly flag for sensitive cookies 
            };
            Response.Cookies.Add(secretCookie);



            var username = Request.QueryString["q"];
            if (!string.IsNullOrEmpty(username))
            {


                //Whitelisting filter
                Regex r = new Regex("^[a-zA-Z0-9 ]*$");
                if (r.IsMatch(username))
                {
                    //Output encoding 
                    string encodedUsername = AntiXssEncoder.XmlAttributeEncode(username);
                    lbl_welcome.Text = "Welcome to our site " + encodedUsername;
                }
                else
                    lbl_welcome.Text = "Please use characters and numbers only";
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