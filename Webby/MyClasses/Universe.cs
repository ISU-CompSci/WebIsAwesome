using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses {
   public static class Universe {
        private static List<Person> _Inhabitants;
        public static string userName;

        public static List<Person> Inhabitants {
            get { return _Inhabitants; }
            set { _Inhabitants = value; }
        }

    }
}
