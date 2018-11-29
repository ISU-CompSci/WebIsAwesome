using MyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webby {
    public partial class Login : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (Universe.Inhabitants != null && !IsPostBack ) {
                foreach (Person p in Universe.Inhabitants) {
                    ddlPeople.Items.Add(p.ToString());
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e) {
            //Universe.userName = txtName.Text;
            Session.Add("UserName", txtName.Text);
        }

        protected void btnShow_Click(object sender, EventArgs e) {
            int index;

            int.TryParse(txtIndex.Text,out index);

            lblWho.Text = ddlPeople.Items[index].Text;

            lblWho.Text = ddlPeople.SelectedItem.Text;
        }
    }
}