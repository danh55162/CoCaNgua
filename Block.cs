using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCaNgua
{
    static class Block
    {
        static int FirstNumber()
        {
            Random GetNumber = new Random();
            return GetNumber.Next(1, 7);
        }

        static int SecondNumber()
        {
            Random GetNumber = new Random();
            return GetNumber.Next(1, 7);
        }
    }
}
