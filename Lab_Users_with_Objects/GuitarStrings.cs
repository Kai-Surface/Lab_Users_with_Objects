using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Users_with_Objects
{
    internal class GuitarStrings : Guitar
    {
        public string[] strings = { "E", "A", "D", "G", "B", "e" };

        public string[] Strings { get => strings; set => strings = value; }
    }
}
