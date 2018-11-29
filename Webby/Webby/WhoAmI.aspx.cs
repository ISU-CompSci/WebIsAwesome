using MyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webby {
    public partial class WhoAmI : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btnShow_Click(object sender, EventArgs e) {
            //lblUsername.Text = Universe.userName;
            if (Session["UserName"] != null) {
                lblUsername.Text = Session["UserName"].ToString();
            } else {
                lblUsername.Text = "I have no Idea; please login";

            }
        }
    }
}