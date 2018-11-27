using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webby {
    public partial class Default_old : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btnSayHello_Click(object sender, EventArgs e) {
            //MessageBox.Show("Hello");
            lblOutput.Text = "Hello " + txtInput.Text;
        }
    }
}