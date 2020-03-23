using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class BirthDay
    {
        public DateTime Birthday { get; private set; }
        public int _years;

        public BirthDay(DateTime birthday)

        {
            Birthday = birthday;
        }

        public int Age {


            get { return _years; }

            set { var timespan = DateTime.Today - Birthday;
                var years = timespan.Days / 365;
                _years = years;
            }

        }
    }
}
