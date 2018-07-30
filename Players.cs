using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CoCaNgua
{
    class Players
    {
        public Button[] InHouse = new Button[4];        
        public string Name { get; set; }
        public int SortNumber { get; set; }
        static class Horse1
        {
            static bool Live = false;
            static int Location;
        }
        static class Horse2
        {
            static bool Live = false;
            static int Location;
        }
        static class Horse3
        {
            static bool Live = false;
            static int Location;
        }
        static class Horse4
        {
            static bool Live = false;
            static int Location;
        }
    }
}
