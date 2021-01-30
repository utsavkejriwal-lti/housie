using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousieTicket
{
    public class Numbers
    {
        public int row { get; set; }
        public int col { get; set; }

        public int CellNumber { get { return ((row-1)*9)+col-1; } }
        public int value { get; set; }
    }
}
