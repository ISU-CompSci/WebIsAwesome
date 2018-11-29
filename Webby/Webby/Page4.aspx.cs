using MyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webby {
    public partial class Page4 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            foreach (Person p in Universe.Inhabitants) {
                TableRow supRow = new TableRow();

                // first name
                TableCell supCellFirst = new TableCell();
                supCellFirst.Text = p.FirstName;
                supRow.Controls.Add(supCellFirst);

                // Last Name
                TableCell supCellLast = new TableCell();
                supCellLast.Text = p.LastName;
                supRow.Controls.Add(supCellLast);

                tblPeoples.Controls.Add(supRow);

            }
        }
    }
}