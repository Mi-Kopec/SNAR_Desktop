using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAR_sheet
{
    class CounterDefault
        {
            public string Number { get; set; }
            public override string ToString()
            {
                return "[" + Number + "]";
            }
        }
}
