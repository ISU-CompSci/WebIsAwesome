using MyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webby {
    public partial class Page3 : System.Web.UI.Page {
            HideOut<SuperHero> _HallOfJustice = new HideOut<SuperHero>();
        protected void Page_Load(object sender, EventArgs e) {
            Citizen c = new Citizen("Billy", "Bo");

            SuperHero s1 = new SuperHero("Bat", "Man") { Height = 74 };
            SuperHero s2 = new SuperHero("Squirrel", "Girl") { Height = 54 };
            SuperHero s3 = new SuperHero("Cat", "Woman") { Height = 58 };
            SuperHero s4 = new SuperHero("The", "Flash") { Height = 66 };
            SuperHero s5 = new SuperHero("Ant", "Man") { Height = 64 };
            SuperHero s6 = new SuperHero("Aqua", "Man") { Height = 72 };
            SuperHero s7 = new SuperHero("Wonder", "Woman") { Height = 76 };
            SuperHero s8 = new SuperHero("Spider", "Man") { Height = 62 };

            _HallOfJustice.Members.Add(s1);
            _HallOfJustice.Members.Add(s2);
            _HallOfJustice.Members.Add(s3);
            _HallOfJustice.Members.Add(s4);
            _HallOfJustice.Members.Add(s5);
            _HallOfJustice.Members.Add(s6);
            _HallOfJustice.Members.Add(s7);
            _HallOfJustice.Members.Add(s8);

        }

        protected void btnFillTable_Click(object sender, EventArgs e) {

            foreach (SuperHero sup in _HallOfJustice.Members) {
                TableRow supRow = new TableRow();

                // first name
                TableCell supCellFirst = new TableCell();
                supCellFirst.Text = sup.FirstName;
                supRow.Controls.Add(supCellFirst);

                // Last Name
                TableCell supCellLast = new TableCell();
                supCellLast.Text = sup.LastName;
                supRow.Controls.Add(supCellLast);

                tblSuperHeros.Controls.Add(supRow);
                
            }
        }
    }
}