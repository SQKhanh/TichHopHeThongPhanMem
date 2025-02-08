using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapTX2
{
    internal class DiaChi
    {
        public string xa { get; set; }
        public string huyen { get; set; }
        public string tinh { get; set; }
        public DiaChi() { }

        public override string ToString()
        {
            return $"{xa}, {huyen}, {tinh}";
        }
    }
}
