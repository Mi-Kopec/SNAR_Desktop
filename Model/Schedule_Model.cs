using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAR_sheet.Schedule_Model
{
    public class Unit
    {
        public string Name
        {
            get;
            set;
        }

        public ICollection<Number> Numbers
        {
            get;
            set;
        }
    }

    public class Number
    {
        public int Name
        {
            get;
            set;
        }

    }
}
