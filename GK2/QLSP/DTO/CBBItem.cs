using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLSP
{
    public class CBBItem
    {
        public string Value { get; set; }
        public string Text { get; set; }
        public int SpecialValue { get; set; }
        public override string ToString()
        {
            return Text;
        }
    }
}
