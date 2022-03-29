using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1
{
    public struct LQ
    {
        private char _letter;
        private int _quantity;

        public char letter
        {
            get { return _letter; }
            set { _letter = value; }
        }

        public int quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        } 
    }
}
