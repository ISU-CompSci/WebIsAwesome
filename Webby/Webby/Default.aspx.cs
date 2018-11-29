using MyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webby {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            SuperHero s = new SuperHero();
            s.FirstName = "Bob";
            //lblOutPut.Text = s.FirstName;

            SuperHero s1 = new SuperHero("Bat", "Man") { Height = 74 };
            SuperHero s2 = new SuperHero("Squirrel", "Girl") { Height = 54 };
            SuperHero s3 = new SuperHero("Cat", "Woman") { Height = 58 };
            SuperHero s4 = new SuperHero("The", "Flash") { Height = 66 };
            SuperHero s5 = new SuperHero("Ant", "Man") { Height = 64 };
            SuperHero s6 = new SuperHero("Aqua", "Man") { Height = 72 };
            SuperHero s7 = new SuperHero("Wonder", "Woman") { Height = 76 };
            SuperHero s8 = new SuperHero("Spider", "Man") { Height = 62 };

            Universe.Inhabitants = new List<Person>();
            Universe.Inhabitants.Add(s);
            Universe.Inhabitants.Add(s1);
            Universe.Inhabitants.Add(s2);
            Universe.Inhabitants.Add(s3);
            Universe.Inhabitants.Add(s4);
            Universe.Inhabitants.Add(s5);
            Universe.Inhabitants.Add(s6);
            Universe.Inhabitants.Add(s7);
            Universe.Inhabitants.Add(s8);

            lblOutPut.Text = "I Loaded the peoples to the Universe.";

        }
    }
}